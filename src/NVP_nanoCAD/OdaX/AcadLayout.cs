using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the plot settings and visual properties of a model space or paper space block
///</summary>
namespace OdaX.AcadLayout 
{

	[NVP_Manifest(
		Id = "5DA499EA-2821-4D32-83E4-539B78AF6C8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayout.AcadLayout_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayout", 
		NodeName = "_AcadLayout_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayout_Constructor : INode 
	{
		public OdaX.IAcadLayout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLayout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3F72BB14-B542-4D23-9C96-D27D812D98EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayout.AcadLayout_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayout", 
		NodeName = "_AcadLayout_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayout_ConstructorCast : INode 
	{
		public OdaX.IAcadLayout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLayout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0669A957-B937-46E4-B6C1-740C416D6BC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayout.Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayout", 
		NodeName = "Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the block of a layout.", 
		ViewType = "Data")]
	[NodeInput("AcadLayout", typeof(object))]

	///<summary>
	///Returns the block of a layout.
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
		Id = "215499DD-2957-43EE-A651-859344C0D8A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayout.TabOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayout", 
		NodeName = "TabOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of the specified layout.", 
		ViewType = "Data")]
	[NodeInput("AcadLayout", typeof(object))]

	///<summary>
	///Specifies or returns the order of the specified layout.
	///</summary>
	public class TabOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TabOrder);

		}
	}


	[NVP_Manifest(
		Id = "B365156B-E525-4AEF-9291-ACF5348B0016", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayout.Set_TabOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayout", 
		NodeName = "Set_TabOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of the specified layout.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayout", typeof(object))]
	[NodeInput("pOrder", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of the specified layout.
	///</summary>
	public class Set_TabOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TabOrder = inputs[1].Value;
			return null;
		}
	}
}
