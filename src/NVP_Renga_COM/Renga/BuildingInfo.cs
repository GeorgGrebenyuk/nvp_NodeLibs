using NVP.API.Nodes;

namespace Renga.BuildingInfo 
{
		[NodeInput("dynamic", typeof(object))]
		public class BuildingInfo_Constructor : INode 
		{
		public Renga.IBuildingInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IBuildingInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class BuildingInfo_ConstructorCast : INode 
		{
		public Renga.IBuildingInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IBuildingInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class Number : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Number);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		[NodeInput("pNumber", typeof(System.String))]
		public class Set_Number : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Number = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		[NodeInput("pName", typeof(System.String))]
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
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		[NodeInput("pDescription", typeof(System.String))]
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
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class GetAddress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAddress);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class GetProperties : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetProperties);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class UniqueId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UniqueId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BuildingInfo", typeof(object))]
		public class UniqueIdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UniqueIdS);

			}
		}
}
