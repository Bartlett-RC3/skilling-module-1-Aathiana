using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 10;
        [SerializeField] private int _countY = 10;

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;

        private int[] _cellAges;

        //Declare the Coroutine for color changing [AA]
        IEnumerator createCellCoroutine;


        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            // create cell array
            _cells = new Cell[_countY, _countX];

            // instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                }
            }

            // create model
            _model = new GameOfLife2D(_countY, _countX);

            //Initialize the Age array
            _cellAges = new int[_countY * _countX];

            // initialize model 
            _initializer.Initialize(_model.CurrentState);

            // Start the Coroutine [AA]
            createCellCoroutine = ChangeCellColors();
            StartCoroutine(createCellCoroutine);
        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            _model.Step();
            _stepCount++;
            // Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;

            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                    _cells[y, x].State = state[y, x];
            }

            StoreCellAges();    //[AA]
        }


        /// <summary>
        /// Store the Ages of the cells in a singe array to use in Coroutine [AA]
        /// </summary>
        private void StoreCellAges()
        {
            //Initialize a temporal array to store the current states of the cells 
            int[,] currentCellState = new int[_countY, _countX];

            int index = 0;

            for (int x = 0; x < _countX; x++)
            {
                for (int y = 0; y < _countY; y++)
                {
                    currentCellState[y, x] = _cells[y, x].State;
                    //Debug.Log($"The state of the cell is:{ currentState[y, x]}");

                    if (currentCellState[y, x] == 1)
                    {
                        _cellAges[index] += 1;
                        //Debug.Log($"The Age of the cell is:{ _cellAges[index]}");
                    }
                    else
                    {
                        _cellAges[index] = 0;
                        //Debug.Log($"The Age of the cell is:{ _cellAges[index]}");
                    }
                    index++;
                }
            }
        }


        /// <summary>
        /// Use a coroutine to change the colours of the Cells based on time spent alive [AA]
        /// </summary>
        /// <returns></returns>
        IEnumerator ChangeCellColors()
        {
            while (true)
            {
                int index = 0;
                foreach (var cell in _cells)
                {
                    if (_cellAges[index] > 1)     //Change the Color of the cells if the age is bigger than 1) [AA]
                        cell.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
                    else
                        cell.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);

                    index++;
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
