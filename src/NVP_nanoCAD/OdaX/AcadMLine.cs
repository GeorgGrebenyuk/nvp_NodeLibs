using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of multiple parallel lines
///</summary>
namespace OdaX.AcadMLine 
{

	[NVP_Manifest(
		Id = "6073E18E-DA0D-438B-9A02-EC64E3C5450A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.AcadMLine_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "_AcadMLine_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLine_Constructor : INode 
	{
		public OdaX.IAcadMLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6264D3D8-17BC-4592-880D-96155E8C03FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.AcadMLine_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "_AcadMLine_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLine_ConstructorCast : INode 
	{
		public OdaX.IAcadMLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C356B6E9-05D7-48AD-8955-38740C207A7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the style name of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Returns the style name of a multiline.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Id = "20A7065D-66DC-4818-B400-C1C15A46414F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices of a multline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the vertices of a multline.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Id = "DCE792D3-151B-4FE5-8BF4-A9B69C930505", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices of a multline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("Vertices", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices of a multline.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C8127BBC-A9C1-42F6-83B8-14D068A0A076", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.Justification", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "Justification", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the orientation of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the orientation of a multiline.
	///</summary>
	public class Justification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Justification);

		}
	}


	[NVP_Manifest(
		Id = "EEA7E904-1DF9-4F29-A90D-9814D45EE5DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.Set_Justification", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "Set_Justification", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the orientation of a multiline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("OdaX.AcMLineJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the orientation of a multiline.
	///</summary>
	public class Set_Justification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Justification = ((OdaX.AcMLineJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BD19B71-C25B-42F6-B0AD-CB44EB6088FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.MLineScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "MLineScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the scale of a multiline.
	///</summary>
	public class MLineScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MLineScale);

		}
	}


	[NVP_Manifest(
		Id = "B5EAF914-A6BF-42BA-8DB4-FF58AB0D990B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLine.Set_MLineScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLine", 
		NodeName = "Set_MLineScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale of a multiline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale of a multiline.
	///</summary>
	public class Set_MLineScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MLineScale = inputs[1].Value;
			return null;
		}
	}
}
