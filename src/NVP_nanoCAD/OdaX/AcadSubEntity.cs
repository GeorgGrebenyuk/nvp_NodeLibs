using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///SubEntity Interface
///</summary>
namespace OdaX.AcadSubEntity 
{

	[NVP_Manifest(
		Id = "3CFACD8F-4FC4-41CA-8733-9EDF0DC83D0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.AcadSubEntity_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "_AcadSubEntity_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_Constructor : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "0C59602A-946D-4613-8E20-BE634A704015", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.AcadSubEntity_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "_AcadSubEntity_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D1721B31-3934-456D-B9C6-6D3279BF592B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.OnModified", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "OnModified", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnModified : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnModified();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9158E281-DEE3-43B8-AEDD-11894BDFC580", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.ObjectName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "ObjectName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the AutoCAD class name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Gets the AutoCAD class name of the object
	///</summary>
	public class ObjectName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectName);

		}
	}


	[NVP_Manifest(
		Id = "5CDE98AF-761F-49AB-B47B-60E1D1D4D6AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the true color of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Returns the true color of the object.
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Id = "3A949650-1A05-4912-8842-DC80E7E32E0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.Set_color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "Set_color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the true color of the object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntity", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Returns the true color of the object.
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8BB07EBD-7C8D-4517-9AEC-FEB2794B1AF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current layer of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the current layer of the object
	///</summary>
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	[NVP_Manifest(
		Id = "F5A5521F-B199-4099-BF91-8FAB18BB50E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current linetype of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the current linetype of the object
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Id = "DE42CCFD-BE87-4714-A843-5A673D2614D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.LinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "LinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype scale factor of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the linetype scale factor of the object
	///</summary>
	public class LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "A7BC191E-C7C1-4CAA-B0C6-02CD922D0F48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the plotstyle name for the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the plotstyle name for the object
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "DDB7AF03-26B9-4F73-8D4C-FAA798F8E0BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the lineweight for the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the lineweight for the object
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Id = "99170AA9-A51E-4760-B737-34F4533AA763", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntity.Hyperlinks", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntity", 
		NodeName = "Hyperlinks", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "if one is specified)", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///if one is specified)
	///</summary>
	public class Hyperlinks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hyperlinks);

		}
	}
}
