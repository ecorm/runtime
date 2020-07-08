// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.General
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Vector64Zero"] = Vector64Zero,
                ["Vector64AllBitsSet"] = Vector64AllBitsSet,
                ["Vector64BooleanAsGeneric_Boolean"] = Vector64BooleanAsGeneric_Boolean,
                ["Vector64ByteAsGeneric_Boolean"] = Vector64ByteAsGeneric_Boolean,
                ["Vector64DoubleAsGeneric_Boolean"] = Vector64DoubleAsGeneric_Boolean,
                ["Vector64Int16AsGeneric_Boolean"] = Vector64Int16AsGeneric_Boolean,
                ["Vector64Int32AsGeneric_Boolean"] = Vector64Int32AsGeneric_Boolean,
                ["Vector64Int64AsGeneric_Boolean"] = Vector64Int64AsGeneric_Boolean,
                ["Vector64SByteAsGeneric_Boolean"] = Vector64SByteAsGeneric_Boolean,
                ["Vector64SingleAsGeneric_Boolean"] = Vector64SingleAsGeneric_Boolean,
                ["Vector64UInt16AsGeneric_Boolean"] = Vector64UInt16AsGeneric_Boolean,
                ["Vector64UInt32AsGeneric_Boolean"] = Vector64UInt32AsGeneric_Boolean,
                ["Vector64UInt64AsGeneric_Boolean"] = Vector64UInt64AsGeneric_Boolean,
                ["Vector64BooleanAsGeneric_Byte"] = Vector64BooleanAsGeneric_Byte,
                ["Vector64BooleanAsGeneric_Double"] = Vector64BooleanAsGeneric_Double,
                ["Vector64BooleanAsGeneric_Int16"] = Vector64BooleanAsGeneric_Int16,
                ["Vector64BooleanAsGeneric_Int32"] = Vector64BooleanAsGeneric_Int32,
                ["Vector64BooleanAsGeneric_Int64"] = Vector64BooleanAsGeneric_Int64,
                ["Vector64BooleanAsGeneric_SByte"] = Vector64BooleanAsGeneric_SByte,
                ["Vector64BooleanAsGeneric_Single"] = Vector64BooleanAsGeneric_Single,
                ["Vector64BooleanAsGeneric_UInt16"] = Vector64BooleanAsGeneric_UInt16,
                ["Vector64BooleanAsGeneric_UInt32"] = Vector64BooleanAsGeneric_UInt32,
                ["Vector64BooleanAsGeneric_UInt64"] = Vector64BooleanAsGeneric_UInt64,
                ["Vector64BooleanAsByte"] = Vector64BooleanAsByte,
                ["Vector64BooleanAsDouble"] = Vector64BooleanAsDouble,
                ["Vector64BooleanAsInt16"] = Vector64BooleanAsInt16,
                ["Vector64BooleanAsInt32"] = Vector64BooleanAsInt32,
                ["Vector64BooleanAsInt64"] = Vector64BooleanAsInt64,
                ["Vector64BooleanAsSByte"] = Vector64BooleanAsSByte,
                ["Vector64BooleanAsSingle"] = Vector64BooleanAsSingle,
                ["Vector64BooleanAsUInt16"] = Vector64BooleanAsUInt16,
                ["Vector64BooleanAsUInt32"] = Vector64BooleanAsUInt32,
                ["Vector64BooleanAsUInt64"] = Vector64BooleanAsUInt64,
                ["Vector64GetElementNegativeOne"] = Vector64GetElementNegativeOne,
                ["Vector64GetElement0"] = Vector64GetElement0,
                ["Vector64GetElementMaxValue"] = Vector64GetElementMaxValue,
                ["Vector64WithElementNegativeOne"] = Vector64WithElementNegativeOne,
                ["Vector64WithElement0"] = Vector64WithElement0,
                ["Vector64WithElementMaxValue"] = Vector64WithElementMaxValue,
                ["Vector64ToScalar"] = Vector64ToScalar,
                ["Vector64ToVector128"] = Vector64ToVector128,
                ["Vector64ToVector128Unsafe"] = Vector64ToVector128Unsafe,
                ["Vector64ToString"] = Vector64ToString,
                ["Vector128Zero"] = Vector128Zero,
                ["Vector128AllBitsSet"] = Vector128AllBitsSet,
                ["Vector128BooleanAsGeneric_Boolean"] = Vector128BooleanAsGeneric_Boolean,
                ["Vector128ByteAsGeneric_Boolean"] = Vector128ByteAsGeneric_Boolean,
                ["Vector128DoubleAsGeneric_Boolean"] = Vector128DoubleAsGeneric_Boolean,
                ["Vector128Int16AsGeneric_Boolean"] = Vector128Int16AsGeneric_Boolean,
                ["Vector128Int32AsGeneric_Boolean"] = Vector128Int32AsGeneric_Boolean,
                ["Vector128Int64AsGeneric_Boolean"] = Vector128Int64AsGeneric_Boolean,
                ["Vector128SByteAsGeneric_Boolean"] = Vector128SByteAsGeneric_Boolean,
                ["Vector128SingleAsGeneric_Boolean"] = Vector128SingleAsGeneric_Boolean,
                ["Vector128UInt16AsGeneric_Boolean"] = Vector128UInt16AsGeneric_Boolean,
                ["Vector128UInt32AsGeneric_Boolean"] = Vector128UInt32AsGeneric_Boolean,
                ["Vector128UInt64AsGeneric_Boolean"] = Vector128UInt64AsGeneric_Boolean,
                ["Vector128BooleanAsGeneric_Byte"] = Vector128BooleanAsGeneric_Byte,
                ["Vector128BooleanAsGeneric_Double"] = Vector128BooleanAsGeneric_Double,
                ["Vector128BooleanAsGeneric_Int16"] = Vector128BooleanAsGeneric_Int16,
                ["Vector128BooleanAsGeneric_Int32"] = Vector128BooleanAsGeneric_Int32,
                ["Vector128BooleanAsGeneric_Int64"] = Vector128BooleanAsGeneric_Int64,
                ["Vector128BooleanAsGeneric_SByte"] = Vector128BooleanAsGeneric_SByte,
                ["Vector128BooleanAsGeneric_Single"] = Vector128BooleanAsGeneric_Single,
                ["Vector128BooleanAsGeneric_UInt16"] = Vector128BooleanAsGeneric_UInt16,
                ["Vector128BooleanAsGeneric_UInt32"] = Vector128BooleanAsGeneric_UInt32,
                ["Vector128BooleanAsGeneric_UInt64"] = Vector128BooleanAsGeneric_UInt64,
                ["Vector128BooleanAsByte"] = Vector128BooleanAsByte,
                ["Vector128BooleanAsDouble"] = Vector128BooleanAsDouble,
                ["Vector128BooleanAsInt16"] = Vector128BooleanAsInt16,
                ["Vector128BooleanAsInt32"] = Vector128BooleanAsInt32,
                ["Vector128BooleanAsInt64"] = Vector128BooleanAsInt64,
                ["Vector128BooleanAsSByte"] = Vector128BooleanAsSByte,
                ["Vector128BooleanAsSingle"] = Vector128BooleanAsSingle,
                ["Vector128BooleanAsUInt16"] = Vector128BooleanAsUInt16,
                ["Vector128BooleanAsUInt32"] = Vector128BooleanAsUInt32,
                ["Vector128BooleanAsUInt64"] = Vector128BooleanAsUInt64,
                ["Vector128GetElementNegativeOne"] = Vector128GetElementNegativeOne,
                ["Vector128GetElement0"] = Vector128GetElement0,
                ["Vector128GetElementMaxValue"] = Vector128GetElementMaxValue,
                ["Vector128WithElementNegativeOne"] = Vector128WithElementNegativeOne,
                ["Vector128WithElement0"] = Vector128WithElement0,
                ["Vector128WithElementMaxValue"] = Vector128WithElementMaxValue,
                ["Vector128GetLower"] = Vector128GetLower,
                ["Vector128WithLower"] = Vector128WithLower,
                ["Vector128GetUpper"] = Vector128GetUpper,
                ["Vector128WithUpper"] = Vector128WithUpper,
                ["Vector128ToScalar"] = Vector128ToScalar,
                ["Vector128ToVector256"] = Vector128ToVector256,
                ["Vector128ToVector256Unsafe"] = Vector128ToVector256Unsafe,
                ["Vector128ToString"] = Vector128ToString,
                ["Vector256Zero"] = Vector256Zero,
                ["Vector256AllBitsSet"] = Vector256AllBitsSet,
                ["Vector256BooleanAsGeneric_Boolean"] = Vector256BooleanAsGeneric_Boolean,
                ["Vector256ByteAsGeneric_Boolean"] = Vector256ByteAsGeneric_Boolean,
                ["Vector256DoubleAsGeneric_Boolean"] = Vector256DoubleAsGeneric_Boolean,
                ["Vector256Int16AsGeneric_Boolean"] = Vector256Int16AsGeneric_Boolean,
                ["Vector256Int32AsGeneric_Boolean"] = Vector256Int32AsGeneric_Boolean,
                ["Vector256Int64AsGeneric_Boolean"] = Vector256Int64AsGeneric_Boolean,
                ["Vector256SByteAsGeneric_Boolean"] = Vector256SByteAsGeneric_Boolean,
                ["Vector256SingleAsGeneric_Boolean"] = Vector256SingleAsGeneric_Boolean,
                ["Vector256UInt16AsGeneric_Boolean"] = Vector256UInt16AsGeneric_Boolean,
                ["Vector256UInt32AsGeneric_Boolean"] = Vector256UInt32AsGeneric_Boolean,
                ["Vector256UInt64AsGeneric_Boolean"] = Vector256UInt64AsGeneric_Boolean,
                ["Vector256BooleanAsGeneric_Byte"] = Vector256BooleanAsGeneric_Byte,
                ["Vector256BooleanAsGeneric_Double"] = Vector256BooleanAsGeneric_Double,
                ["Vector256BooleanAsGeneric_Int16"] = Vector256BooleanAsGeneric_Int16,
                ["Vector256BooleanAsGeneric_Int32"] = Vector256BooleanAsGeneric_Int32,
                ["Vector256BooleanAsGeneric_Int64"] = Vector256BooleanAsGeneric_Int64,
                ["Vector256BooleanAsGeneric_SByte"] = Vector256BooleanAsGeneric_SByte,
                ["Vector256BooleanAsGeneric_Single"] = Vector256BooleanAsGeneric_Single,
                ["Vector256BooleanAsGeneric_UInt16"] = Vector256BooleanAsGeneric_UInt16,
                ["Vector256BooleanAsGeneric_UInt32"] = Vector256BooleanAsGeneric_UInt32,
                ["Vector256BooleanAsGeneric_UInt64"] = Vector256BooleanAsGeneric_UInt64,
                ["Vector256BooleanAsByte"] = Vector256BooleanAsByte,
                ["Vector256BooleanAsDouble"] = Vector256BooleanAsDouble,
                ["Vector256BooleanAsInt16"] = Vector256BooleanAsInt16,
                ["Vector256BooleanAsInt32"] = Vector256BooleanAsInt32,
                ["Vector256BooleanAsInt64"] = Vector256BooleanAsInt64,
                ["Vector256BooleanAsSByte"] = Vector256BooleanAsSByte,
                ["Vector256BooleanAsSingle"] = Vector256BooleanAsSingle,
                ["Vector256BooleanAsUInt16"] = Vector256BooleanAsUInt16,
                ["Vector256BooleanAsUInt32"] = Vector256BooleanAsUInt32,
                ["Vector256BooleanAsUInt64"] = Vector256BooleanAsUInt64,
                ["Vector256GetElementNegativeOne"] = Vector256GetElementNegativeOne,
                ["Vector256GetElement0"] = Vector256GetElement0,
                ["Vector256GetElementMaxValue"] = Vector256GetElementMaxValue,
                ["Vector256WithElementNegativeOne"] = Vector256WithElementNegativeOne,
                ["Vector256WithElement0"] = Vector256WithElement0,
                ["Vector256WithElementMaxValue"] = Vector256WithElementMaxValue,
                ["Vector256GetLower"] = Vector256GetLower,
                ["Vector256WithLower"] = Vector256WithLower,
                ["Vector256GetUpper"] = Vector256GetUpper,
                ["Vector256WithUpper"] = Vector256WithUpper,
                ["Vector256ToScalar"] = Vector256ToScalar,
                ["Vector256ToString"] = Vector256ToString,
            };
        }
    }
}