using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a rectangular array of block references
///</summary>
namespace OdaX.AcadMInsertBlock 
{

	[NVP_Manifest(
		Id = "7F6BC53B-34C7-4B26-ABF2-6FAF765FAD9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.AcadMInsertBlock_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "_AcadMInsertBlock_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMInsertBlock_Constructor : INode 
	{
		public OdaX.IAcadMInsertBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMInsertBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "82D08AB5-5973-434D-88B7-D5952B222D00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.AcadMInsertBlock_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "_AcadMInsertBlock_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMInsertBlock_ConstructorCast : INode 
	{
		public OdaX.IAcadMInsertBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMInsertBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "401F4685-6FB0-4BAB-AC9E-0B3A1BEBE6EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Set_Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Set_Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of vertical columns in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumColumns", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "92860BA3-5162-4A52-AD68-C990F2C9BA18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of vertical columns in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	[NVP_Manifest(
		Id = "D8068C4B-2AFA-4918-85E4-285EEA95674A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Set_ColumnSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Set_ColumnSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the spacing between columns in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	public class Set_ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45055609-778B-485E-B358-D40FA367AA7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.ColumnSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "ColumnSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the spacing between columns in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	public class ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnSpacing);

		}
	}


	[NVP_Manifest(
		Id = "ACC06B65-BC0B-4E56-B699-ECFE03F21A6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Set_Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Set_Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of horizontal rows in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumRows", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B50CEA56-4DA0-4590-BB8C-8887BCAD5825", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of horizontal rows in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	[NVP_Manifest(
		Id = "0B2C9CD0-F79D-48AF-BEAD-77290DEF67CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.Set_RowSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "Set_RowSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the spacing between rows in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	public class Set_RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "218496FB-F7B0-4CD5-A28E-07F4D4A6D903", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMInsertBlock.RowSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMInsertBlock", 
		NodeName = "RowSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the spacing between rows in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	public class RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowSpacing);

		}
	}
}
