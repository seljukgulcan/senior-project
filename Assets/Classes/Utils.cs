﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Utility classes
/// </summary>
public class Utils {

    /// <summary>
    /// Assumes table is not empty and columnNo is valid
    /// </summary>
    /// <param name="table"></param>
    /// <param name="columnNo"></param>
    /// <returns></returns>
    public static IntFloatPair MinColumn( float[,] table, int columnNo) {

        float min = table[0,columnNo];
        int index = 0;

        for( int i = 1; i < table.GetLength(0); i++) {

            float current = table[i, columnNo];
            if (current < min) {

                min = current;
                index = i;
            }
        }

        return new IntFloatPair( index, min);
    }

    public static void Log( string message, int channel) {

    }
}

public class IntFloatPair {

    public int Index { get; set; }
    public float Value { get; set; }

    public IntFloatPair( int index, float value) {

        this.Index = index;
        this.Value = value;
    }
}