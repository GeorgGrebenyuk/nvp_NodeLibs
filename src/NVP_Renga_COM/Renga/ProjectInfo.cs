using NVP.API.Nodes;

namespace Renga.ProjectInfo 
{
		[NodeInput("dynamic", typeof(object))]
		public class ProjectInfo_Constructor : INode 
		{
		public Renga.IProjectInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IProjectInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ProjectInfo_ConstructorCast : INode 
		{
		public Renga.IProjectInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IProjectInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ProjectInfo", typeof(object))]
		public class Code : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Code);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ProjectInfo", typeof(object))]
		[NodeInput("pCode", typeof(System.String))]
		public class Set_Code : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Code = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
		public class Stage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Stage);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ProjectInfo", typeof(object))]
		[NodeInput("pStage", typeof(System.String))]
		public class Set_Stage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Stage = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
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
		[NodeInput("ProjectInfo", typeof(object))]
		public class UniqueIdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UniqueIdS);

			}
		}
}
