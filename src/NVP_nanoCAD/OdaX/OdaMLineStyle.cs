using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to define a style for multiple parallel lines
///</summary>
namespace OdaX.OdaMLineStyle 
{

	[NVP_Manifest(
		Id = "96D9074D-AF0E-4C80-B5CF-26E784C2D674", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.OdaMLineStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "_OdaMLineStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyle_Constructor : INode 
	{
		public OdaX.IOdaMLineStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaMLineStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9680FD4E-198C-49D0-9364-7F9335D10AA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.OdaMLineStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "_OdaMLineStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyle_ConstructorCast : INode 
	{
		public OdaX.IOdaMLineStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaMLineStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C7AC840D-EE9B-48D2-B95A-1ECE99AD53C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "1BB3BF6D-382C-4B3E-88FA-C3DBF9B957D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "04DD9B32-937E-4943-B638-35F87B7E58C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the style description", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///Specifies the style description
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "ADC5B7E6-C423-47DE-904A-BB7623BFE827", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the style description", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("bstrDes", typeof(System.String))]

	///<summary>
	///Specifies the style description
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D9A2212E-B888-418E-A2C4-2146FF0D66B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartAngle", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property StartAngle
	///</summary>
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	[NVP_Manifest(
		Id = "418EB3DF-F772-49BF-AED4-8C1A5C6C72A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartAngle", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartAngle
	///</summary>
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FDFC6D5-8E4C-4757-9C62-7F044FEAFB1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndAngle", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property EndAngle
	///</summary>
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	[NVP_Manifest(
		Id = "2B60BAD6-17EB-4765-A365-DC6FB8FFC6E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndAngle", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndAngle
	///</summary>
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CBBA4F7D-12DA-4A1E-B7C2-DE1C789BE1C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.FillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "FillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FillColor", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property FillColor
	///</summary>
	public class FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillColor);

		}
	}


	[NVP_Manifest(
		Id = "E1FCCC85-1465-40D0-A980-26AF2C75960F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_FillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_FillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FillColor", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FillColor
	///</summary>
	public class Set_FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CA259592-76BF-4E97-9D3F-5567C399BDDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.ElementsCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "ElementsCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "returns the number of elements in style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///returns the number of elements in style
	///</summary>
	public class ElementsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementsCount);

		}
	}


	[NVP_Manifest(
		Id = "B8F90A03-DEDB-40AF-9F35-BAD12AC45AE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Filled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Filled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x01)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	public class Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Filled);

		}
	}


	[NVP_Manifest(
		Id = "2493C2B8-650F-4330-9130-2E60B6D9925C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_Filled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_Filled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x01)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	public class Set_Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Filled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F207026E-55B6-4C14-9032-C9BA96807C00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.ShowMiters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "ShowMiters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x02)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	public class ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMiters);

		}
	}


	[NVP_Manifest(
		Id = "B3D9460B-9507-4D44-9934-B3268BDA9E16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_ShowMiters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_ShowMiters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x02)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	public class Set_ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowMiters = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E06E484-802E-49C3-B634-86521E020D07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.StartSquareCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "StartSquareCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x10)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	public class StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartSquareCap);

		}
	}


	[NVP_Manifest(
		Id = "07BD2557-112A-4230-B63A-8A142F617CB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_StartSquareCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_StartSquareCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x10)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	public class Set_StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartSquareCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5A52E46A-1D6B-4186-BA21-ECA3DB4805BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.StartRoundCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "StartRoundCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x40)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	public class StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartRoundCap);

		}
	}


	[NVP_Manifest(
		Id = "E7ED3989-708E-4713-AD4C-0FD698987D95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_StartRoundCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_StartRoundCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x40)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	public class Set_StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartRoundCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E2E81A71-3128-4484-91FE-4DDC9BB0F4EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.StartInnerArcs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "StartInnerArcs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x20)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	public class StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartInnerArcs);

		}
	}


	[NVP_Manifest(
		Id = "0FF9EB87-A8D9-4B75-BDF6-049FFEFD1788", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_StartInnerArcs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_StartInnerArcs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x20)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	public class Set_StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartInnerArcs = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "55772C5F-9C96-4FB9-81AA-FDB0C01F0CBC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.EndSquareCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "EndSquareCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x80)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	public class EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndSquareCap);

		}
	}


	[NVP_Manifest(
		Id = "A1F88F6A-583E-4A4F-A502-D9DED18AAAFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_EndSquareCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_EndSquareCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x80)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	public class Set_EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndSquareCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "28B61CE9-351C-460E-BF41-36DADF588A70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.EndRoundCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "EndRoundCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x200)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	public class EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndRoundCap);

		}
	}


	[NVP_Manifest(
		Id = "0ADB1F1D-92B6-4A78-90E6-1D1034D1FD53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_EndRoundCap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_EndRoundCap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x200)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	public class Set_EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndRoundCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3142155-9FAC-4B3B-8685-A083174890F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.EndInnerArcs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "EndInnerArcs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x100)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	public class EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndInnerArcs);

		}
	}


	[NVP_Manifest(
		Id = "2FA966FE-37E4-4986-AB88-FE09B1CA88A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_EndInnerArcs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_EndInnerArcs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DXF 70, bit 0x100)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	public class Set_EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndInnerArcs = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25831321-E8E9-4693-9D1D-BE31E77BBD49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.AddElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "AddElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds an element to this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]
	[NodeInput("color", typeof(System.Object))]
	[NodeInput("pLinetype", typeof(System.Object))]

	///<summary>
	///Adds an element to this MLine Style
	///</summary>
	public class AddElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddElement(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3E16A4B9-B070-4D8B-AD48-4A86B42AE8E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.OffsetAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "OffsetAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the offset values for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	public class OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DF99D579-4542-4B06-BFFB-14DC1F25D8A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_OffsetAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_OffsetAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the offset values for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	public class Set_OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3E27429B-564E-4167-9BD2-B9C300794268", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.ColorAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "ColorAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Color object for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	public class ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5011B0F6-582E-4158-8451-2965AA0271EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_ColorAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_ColorAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Color object for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	public class Set_ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FD980F06-1A23-4628-8538-22B702CB43B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.LineTypeAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "LineTypeAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Line Type object for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
	public class LineTypeAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FCCB522C-7D86-470C-A866-32F0D7A9F39F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyle.Set_LineTypeAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyle", 
		NodeName = "Set_LineTypeAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Line Type object for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
	public class Set_LineTypeAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeAt[inputs[1]] = inputs[2];
			return null;
		}
	}
}
