using NVP.API.Nodes;

namespace OdaX.AcadObject 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadObject_Constructor : INode 
		{
		public OdaX.IAcadObject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadObject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadObject_ConstructorCast : INode 
		{
		public OdaX.IAcadObject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadObject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the handle of an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class Handle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Handle);

			}
		}


		///<summary>
		///Returns the TeighaX class name of an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class ObjectName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectName);

			}
		}


		///<summary>
		///XData) associated with an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		[NodeInput("AppName", typeof(System.String))]
		[NodeInput("XDataType", typeof(System.Object))]
		[NodeInput("XDataValue", typeof(System.Object))]
		public class GetXData : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetXData(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///XData) associated with an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		[NodeInput("XDataType", typeof(System.Object))]
		[NodeInput("XDataValue", typeof(System.Object))]
		public class SetXData : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetXData(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Deletes a specified object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class Delete : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Delete();
				return null;
			}
		}


		///<summary>
		///Returns the object ID of an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class ObjectID : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectID);

			}
		}


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Returns the database in which the object belongs.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class Database : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Database);

			}
		}


		///<summary>
		///Returns whether an object has an associated extension dictionary.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class HasExtensionDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasExtensionDictionary);

			}
		}


		///<summary>
		///Returns the extension dictionary associated with an object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class GetExtensionDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetExtensionDictionary);

			}
		}


		///<summary>
		///Returns the object ID of the parent object.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class OwnerID : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OwnerID);

			}
		}


		///<summary>
		///Returns the drawing to which an object belongs.
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class Document : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Document);

			}
		}


		///<summary>
		///Erases all the objects in a selection set
		///</summary>
		[NodeInput("AcadObject", typeof(object))]
		public class HiddenField_Erase : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return null;
			}
		}
}
