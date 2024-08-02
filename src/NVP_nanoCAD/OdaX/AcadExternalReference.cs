using NVP.API.Nodes;

namespace OdaX.AcadExternalReference 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadExternalReference_Constructor : INode 
		{
		public OdaX.IAcadExternalReference _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadExternalReference;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadExternalReference_ConstructorCast : INode 
		{
		public OdaX.IAcadExternalReference _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadExternalReference;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the source path of an external reference.
		///</summary>
		[NodeInput("AcadExternalReference", typeof(object))]
		public class Path : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Path);

			}
		}


		///<summary>
		///Specifies or returns the source path of an external reference.
		///</summary>
		[NodeInput("AcadExternalReference", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Path : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Path = inputs[1];
				return null;
			}
		}
}
