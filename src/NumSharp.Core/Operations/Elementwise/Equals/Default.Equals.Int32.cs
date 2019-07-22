﻿//Generated by Regex Templating Engine at 21/07/2019 23:20:20 UTC
//template source: C:\Users\Eli-PC\Desktop\SciSharp\NumSharp\src\NumSharp.Core\Operations\Elementwise\Templates\Default.Op.Equals.template.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NumSharp.Backends.Unmanaged;
using NumSharp.Generic;
using NumSharp.Utilities;

namespace NumSharp.Backends
{
    public partial class DefaultEngine
    {
        [MethodImpl((MethodImplOptions)768)]
        [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public unsafe NDArray<bool> EqualsInt32(in NDArray lhs, in NDArray rhs)
        {
            //lhs is NDArray of int
            switch (rhs.GetTypeCode)
            {
#if _REGEN
                %op = "=="
                %op_bool = "=="
                case NPTypeCode.Boolean:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) %(op) (*((bool*)rhs.Address) ? (int) 1 : (int) 0))).MakeGeneric<bool>();;

                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (bool*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
                    //iterate
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current))) %(op_bool) 0 != *(rhs_address + BroadcastedRightShape.GetIndexInShape(current));
                    } while (incr.Next() != null);

                    return ret;
                }

	            %foreach except(supported_currently_supported, "Boolean"), except(supported_currently_supported_lowercase, "bool")%
                case NPTypeCode.#1:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) #(op) *((#2*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (#2*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) #(op) (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                %
                default:
		            throw new NotSupportedException();
#else

                case NPTypeCode.Boolean:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == (*((bool*)rhs.Address) ? (int) 1 : (int) 0))).MakeGeneric<bool>();;

                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (bool*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
                    //iterate
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current))) == 0 != *(rhs_address + BroadcastedRightShape.GetIndexInShape(current));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Byte:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((byte*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (byte*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int16:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((short*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (short*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt16:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((ushort*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (ushort*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int32:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((int*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (int*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt32:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((uint*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (uint*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int64:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((long*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (long*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt64:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == (int) *((ulong*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (ulong*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Char:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((char*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (char*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Double:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((double*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (double*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Single:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((float*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (float*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Decimal:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((int*)lhs.Address) == *((decimal*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (int*)lhs.Address;
                    var rhs_address = (decimal*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDIndexArrayIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetIndexInShape(current)) = (*(lhs_address + BroadcastedLeftShape.GetIndexInShape(current)) == (int) *(rhs_address + BroadcastedRightShape.GetIndexInShape(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                default:
		            throw new NotSupportedException();
#endif
            }
        }
    }
}
