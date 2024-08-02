using NVP.API.Nodes;

namespace OdaX.AcadIdPair 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadIdPair_Constructor : INode 
		{
		public OdaX.IAcadIdPair _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadIdPair;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadIdPair_ConstructorCast : INode 
		{
		public OdaX.IAcadIdPair _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadIdPair;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Determines if the source object in a CopyObjects operation has been cloned
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class IsCloned : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsCloned);

			}
		}


		///<summary>
		///Determines if the owning object in a CopyObjects operation has been translated
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class IsOwnerXlated : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsOwnerXlated);

			}
		}


		///<summary>
		///Determines if the source object in a CopyObjects operation was part of the primary set of objects being copied, or if it was simply owned by a member in the primary set
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class IsPrimary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsPrimary);

			}
		}


		///<summary>
		///The object ID of the source object in the CopyObjects operation
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class key : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.key);

			}
		}


		///<summary>
		///The object ID of the newly created cloned object in the CopyObjects operation
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class Value : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Value);

			}
		}


		///<summary>
		///Gets the Application object.
		///</summary>
		[NodeInput("AcadIdPair", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}
}
