using NVP.API.Nodes;

namespace OdaX.AcadRegisteredApplication 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegisteredApplication_Constructor : INode 
		{
		public OdaX.IAcadRegisteredApplication _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadRegisteredApplication;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegisteredApplication_ConstructorCast : INode 
		{
		public OdaX.IAcadRegisteredApplication _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadRegisteredApplication;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the name of the registered application.
		///</summary>
		[NodeInput("AcadRegisteredApplication", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of the registered application.
		///</summary>
		[NodeInput("AcadRegisteredApplication", typeof(object))]
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
}
