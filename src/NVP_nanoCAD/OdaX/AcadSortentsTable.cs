using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to contain and manipulate draw order information
///</summary>
namespace OdaX.AcadSortentsTable 
{

	[NVP_Manifest(
		Id = "9DFAF57F-6EF0-4D29-AD6E-0D5D80F9B2F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.AcadSortentsTable_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "_AcadSortentsTable_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSortentsTable_Constructor : INode 
	{
		public OdaX.IAcadSortentsTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSortentsTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4CCEB8F0-7EB3-445A-83D7-421A8A8E8B13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.AcadSortentsTable_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "_AcadSortentsTable_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSortentsTable_ConstructorCast : INode 
	{
		public OdaX.IAcadSortentsTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSortentsTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FC38A479-44F7-45C4-AE05-A89619C6E420", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.MoveToBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "MoveToBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves objects to the bottom of the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Moves objects to the bottom of the draw order.
	///</summary>
	public class MoveToBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToBottom(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF15CF4A-60EE-4CC5-ADF8-EF01231FAE91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.MoveToTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "MoveToTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves objects to the top of the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Moves objects to the top of the draw order.
	///</summary>
	public class MoveToTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToTop(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C29374F8-6371-4DFD-826E-FB85FA763D6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.MoveBelow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "MoveBelow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves objects below a specified object in the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]

	///<summary>
	///Moves objects below a specified object in the draw order.
	///</summary>
	public class MoveBelow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveBelow(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EE68617A-C889-4961-9FBC-E930A3431C09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.MoveAbove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "MoveAbove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves objects above a specified object in the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]

	///<summary>
	///Moves objects above a specified object in the draw order.
	///</summary>
	public class MoveAbove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveAbove(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF61C35F-486D-4E83-B4F6-6705CF432924", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.SwapOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "SwapOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Exchanges draw order position for two specified objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Object1", typeof(System.Object))]
	[NodeInput("Object2", typeof(System.Object))]

	///<summary>
	///Exchanges draw order position for two specified objects.
	///</summary>
	public class SwapOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SwapOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78335A63-1404-49EE-ADAB-81C2BA967E0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the block referenced by a sortents table.", 
		ViewType = "Data")]
	[NodeInput("AcadSortentsTable", typeof(object))]

	///<summary>
	///Returns the block referenced by a sortents table.
	///</summary>
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	[NVP_Manifest(
		Id = "BED1AFAF-2844-4102-A222-8F169B35F3E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.GetFullDrawOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "GetFullDrawOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns all objects in the referenced block, sorted by draw order with the bottom-most object first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]

	///<summary>
	///Returns all objects in the referenced block, sorted by draw order with the bottom-most object first.
	///</summary>
	public class GetFullDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFullDrawOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D00FAA76-CC4B-4595-9441-4AE22B347C82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.GetRelativeDrawOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "GetRelativeDrawOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the specified objects, sorted by draw order with the bottom-most object first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]

	///<summary>
	///Returns the specified objects, sorted by draw order with the bottom-most object first.
	///</summary>
	public class GetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRelativeDrawOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A99AE3F4-9DA0-4258-9CFE-AD453B51F64A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSortentsTable.SetRelativeDrawOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSortentsTable", 
		NodeName = "SetRelativeDrawOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the relative draw order for the specified objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Specifies the relative draw order for the specified objects.
	///</summary>
	public class SetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRelativeDrawOrder(inputs[1].Value);
			return null;
		}
	}
}
