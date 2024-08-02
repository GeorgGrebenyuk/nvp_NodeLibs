using NVP.API.Nodes;

namespace Renga._IApplicationEvents 
{
	[NodeInput("dynamic", typeof(object))]
	public class _IApplicationEvents_Constructor : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class _IApplicationEvents_ConstructorCast : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]
	public class OnBeforeApplicationClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeApplicationClose(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]
	public class OnBeforeProjectClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeProjectClose(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	public class OnProjectCreated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectCreated();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]
	public class OnProjectOpened : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectOpened(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]
	public class OnProjectSaved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectSaved(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IApplicationEvents", typeof(object))]
	public class OnProjectClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectClosed();
			return null;
		}
	}
}
