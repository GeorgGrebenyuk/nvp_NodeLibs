using NVP.API.Nodes;

namespace OdaX.AcadBlockReference 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadBlockReference_Constructor : INode 
		{
		public OdaX.IAcadBlockReference _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadBlockReference;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadBlockReference_ConstructorCast : INode 
		{
		public OdaX.IAcadBlockReference _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadBlockReference;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsertionPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("insPoint", typeof(System.Object))]
		public class Set_InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.InsertionPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the name of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("Normal", typeof(System.Object))]
		public class Set_Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Normal = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the rotation angle of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation angle of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("rotAngle", typeof(System.Object))]
		public class Set_Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the XScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class XScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the XScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_XScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the YScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class YScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.YScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the YScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_YScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.YScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the ZScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class ZScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ZScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the ZScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_ZScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ZScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Explodes the block or external reference and returns the individual entities as an array of the object.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class Explode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Explode);

			}
		}


		///<summary>
		///Returns the attributes of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class GetAttributes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAttributes);

			}
		}


		///<summary>
		///Returns the constant attributes of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class GetConstantAttributes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetConstantAttributes);

			}
		}


		///<summary>
		///Returns if a block or external reference has any attributes associated with it.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class HasAttributes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasAttributes);

			}
		}


		///<summary>
		///Returns the original name of a block reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class EffectiveName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EffectiveName);

			}
		}


		///<summary>
		///Returns if a block reference is dynamic.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class IsDynamicBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsDynamicBlock);

			}
		}


		///<summary>
		///Returns the properties of a dynamic block reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class GetDynamicBlockProperties : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetDynamicBlockProperties);

			}
		}


		///<summary>
		///Changes a dynamic block reference to its original state.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class ResetBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ResetBlock();
				return null;
			}
		}


		///<summary>
		///Converts a dynamic block reference to a regular block reference with no name.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class ConvertToAnonymousBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ConvertToAnonymousBlock();
				return null;
			}
		}


		///<summary>
		///Converts a dynamic block reference to a regular block reference with a name.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("newBlockName", typeof(System.String))]
		public class ConvertToStaticBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ConvertToStaticBlock(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Specifies or returns the effective XScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class XEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XEffectiveScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the effective XScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_XEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XEffectiveScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the effective YScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class YEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.YEffectiveScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the effective YScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_YEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.YEffectiveScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the effective ZScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class ZEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ZEffectiveScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the effective ZScale factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_ZEffectiveScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ZEffectiveScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the insertion units of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class InsUnits : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsUnits);

			}
		}


		///<summary>
		///Returns the insertion units factor of a block or external reference.
		///</summary>
		[NodeInput("AcadBlockReference", typeof(object))]
		public class InsUnitsFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsUnitsFactor);

			}
		}
}
