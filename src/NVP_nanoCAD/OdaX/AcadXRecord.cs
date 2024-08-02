using NVP.API.Nodes;

namespace OdaX.AcadXRecord 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadXRecord_Constructor : INode 
		{
		public OdaX.IAcadXRecord _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadXRecord;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadXRecord_ConstructorCast : INode 
		{
		public OdaX.IAcadXRecord _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadXRecord;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
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
		///XRecordData) associated with a dictionary
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
		[NodeInput("XRecordDataType", typeof(System.Object))]
		[NodeInput("XRecordDataValue", typeof(System.Object))]
		public class GetXRecordData : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetXRecordData(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///XRecordData) associated with a dictionary
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
		[NodeInput("XRecordDataType", typeof(System.Object))]
		[NodeInput("XRecordDataValue", typeof(System.Object))]
		public class SetXRecordData : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetXRecordData(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
		public class TranslateIDs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TranslateIDs);

			}
		}


		///<summary>
		///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
		///</summary>
		[NodeInput("AcadXRecord", typeof(object))]
		[NodeInput("xlateIds", typeof(System.Object))]
		public class Set_TranslateIDs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TranslateIDs = inputs[1];
				return null;
			}
		}
}
