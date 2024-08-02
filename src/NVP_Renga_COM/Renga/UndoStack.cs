using NVP.API.Nodes;

namespace Renga.UndoStack 
{
	[NodeInput("dynamic", typeof(object))]
	public class UndoStack_Constructor : INode 
	{
		public Renga.IUndoStack _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IUndoStack;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class UndoStack_ConstructorCast : INode 
	{
		public Renga.IUndoStack _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IUndoStack;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("UndoStack", typeof(object))]
	public class Undo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Undo();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("UndoStack", typeof(object))]
	public class Redo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Redo();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("UndoStack", typeof(object))]
	public class HasUndo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasUndo);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("UndoStack", typeof(object))]
	public class HasRedo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasRedo);

		}
	}
}
