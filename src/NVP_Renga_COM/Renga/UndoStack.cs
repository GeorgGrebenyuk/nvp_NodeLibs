using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.UndoStack 
{

	[NVP_Manifest(
		Id = "6CFCB100-288D-43C3-86B9-573CF5120EE3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.UndoStack_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "_UndoStack_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		Id = "DFAEE42A-106C-4D62-9072-7E51B386B829", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.UndoStack_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "_UndoStack_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Id = "9BDEB29E-3A73-482C-A90B-467B42DD112F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.Undo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "Undo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UndoStack", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Undo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Undo();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB0F8B1C-0B66-4161-A6FA-D8B28742F8D9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.Redo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "Redo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UndoStack", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Redo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Redo();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2377BA11-C149-470C-80A4-89F05F027FC6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.HasUndo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "HasUndo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UndoStack", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasUndo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasUndo);

		}
	}


	[NVP_Manifest(
		Id = "814F3A1A-B095-4B45-B666-6F700548C76A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UndoStack.HasRedo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UndoStack", 
		NodeName = "HasRedo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UndoStack", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasRedo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasRedo);

		}
	}
}
