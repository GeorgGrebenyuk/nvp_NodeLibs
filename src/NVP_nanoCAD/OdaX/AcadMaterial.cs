using NVP.API.Nodes;

namespace OdaX.AcadMaterial 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadMaterial_Constructor : INode 
		{
		public OdaX.IAcadMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadMaterial_ConstructorCast : INode 
		{
		public OdaX.IAcadMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the description of a material.
		///</summary>
		[NodeInput("AcadMaterial", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///Specifies or returns the description of a material.
		///</summary>
		[NodeInput("AcadMaterial", typeof(object))]
		[NodeInput("bstrDes", typeof(System.String))]
		public class Set_Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Description = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the name of a material.
		///</summary>
		[NodeInput("AcadMaterial", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a material.
		///</summary>
		[NodeInput("AcadMaterial", typeof(object))]
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
