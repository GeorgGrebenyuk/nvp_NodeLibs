using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for adding, modifing and deleting table styles
///</summary>
namespace OdaX.AcadTableStyle 
{

	[NVP_Manifest(
		Id = "04F88453-A2D3-40EC-84A8-AC67A36C92E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.AcadTableStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "_AcadTableStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTableStyle_Constructor : INode 
	{
		public OdaX.IAcadTableStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTableStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "98D9F557-FC18-47DB-ACEC-9D63DD11E66E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.AcadTableStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "_AcadTableStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTableStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadTableStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTableStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3091ED90-525A-4494-8109-E3C0C9B1B30D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the name of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the name of a table style.
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
		Id = "71C996C0-794E-42AE-A4E0-23EE5BC52E48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the name of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies or returns the name of a table style.
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
		Id = "87F96998-AF24-47E2-960E-969CAA604979", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a tables tyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the description of a tables tyle.
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
		Id = "4C17FD8F-A7DC-414D-9B17-277B44A20EE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a tables tyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstr", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a tables tyle.
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
		Id = "42CF22A4-244C-43B4-89DD-341EEC406F06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.BitFlags", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "BitFlags", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the operation bit set of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the operation bit set of a table style.
	///</summary>
	public class BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BitFlags);

		}
	}


	[NVP_Manifest(
		Id = "79CC4F10-1CF0-4DCA-B405-46FBE9DCF95A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_BitFlags", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_BitFlags", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the operation bit set of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bitFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the operation bit set of a table style.
	///</summary>
	public class Set_BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BitFlags = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0C02CCD3-17F1-4783-B4B3-46C64C099221", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.FlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "FlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the flow direction of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the flow direction of a table style.
	///</summary>
	public class FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDirection);

		}
	}


	[NVP_Manifest(
		Id = "F93BBD55-0D9E-43BC-82A3-AA728F207698", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_FlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_FlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the flow direction of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcTableDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the flow direction of a table style.
	///</summary>
	public class Set_FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowDirection = ((OdaX.AcTableDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2726B6BA-BE13-475E-B43B-00BA47398AB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.HorzCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "HorzCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal cell margin of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal cell margin of a table style.
	///</summary>
	public class HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorzCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "7E64E922-75CE-49D2-8052-3246C53067F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_HorzCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_HorzCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal cell margin of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("dHorzCellMargin", typeof(System.Double))]

	///<summary>
	///Specifies or returns the horizontal cell margin of a table style.
	///</summary>
	public class Set_HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorzCellMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C2422B5-3887-4D94-B00F-E9ECCC70A2DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.VertCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "VertCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical cell margin of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the vertical cell margin of a table style.
	///</summary>
	public class VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "226B61E9-6446-4023-8E46-4EE9E1A57884", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_VertCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_VertCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical cell margin of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("dVertCellMargin", typeof(System.Double))]

	///<summary>
	///Specifies or returns the vertical cell margin of a table style.
	///</summary>
	public class Set_VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VertCellMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "20C88751-44F1-4646-A6C9-4D2053FA0771", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.TitleSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "TitleSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the table title is visible for a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the table title is visible for a table style.
	///</summary>
	public class TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "3B6840DD-050F-4B08-B141-D6BF2F5174C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_TitleSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_TitleSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the table title is visible for a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the table title is visible for a table style.
	///</summary>
	public class Set_TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TitleSuppressed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "59D68D92-89F6-4EC6-9A81-EAF8B8132F40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.HeaderSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "HeaderSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the header titles are visible for a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the header titles are visible for a table style.
	///</summary>
	public class HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeaderSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "143597EA-C5AD-448C-880F-9C8DC7543FF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_HeaderSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_HeaderSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the header titles are visible for a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the header titles are visible for a table style.
	///</summary>
	public class Set_HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeaderSuppressed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E13E893A-9ECA-4DF9-B55B-222BD1E8EC7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text style name of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the text style name of a row type.
	///</summary>
	public class GetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyle(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "37E3F8EF-E75C-4F1F-9424-562A12180966", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text style name of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the text style name of row types.
	///</summary>
	public class SetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4DDC4A7-7ADE-44B4-B567-4DE1D7479E47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text height of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the text height of a row type.
	///</summary>
	public class GetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "A723BB5E-08E4-4C49-942F-C6B3EC867B0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text height of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]

	///<summary>
	///Specifies the text height of row types.
	///</summary>
	public class SetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "92DB2749-64CC-4F39-A274-8B095F5E4775", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the cell alignment of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the cell alignment of a row type.
	///</summary>
	public class GetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAlignment(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "C37ED406-D264-46E7-8591-E30D5A51EF13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the cell alignment of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Specifies the cell alignment of row types.
	///</summary>
	public class SetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAlignment(inputs[1].Value,((OdaX.AcCellAlignment)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "34A50F9A-F007-4B49-A61F-C6862F3440DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the color value of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the color value of a row type.
	///</summary>
	public class GetColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColor(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "A09B621C-B28E-443A-AA39-FA44BB49711D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color value of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the color value of row types.
	///</summary>
	public class SetColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A0471B94-9DE8-4995-BC6B-59812F22CCA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the background color value of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the background color value of a row type.
	///</summary>
	public class GetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColor(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "24C606A5-27B0-495B-9230-F5A6E562D776", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the background color value of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the background color value of row types.
	///</summary>
	public class SetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF6A7A5A-ECBA-444C-A1E3-494F29767A0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the background color is set to None for a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns whether the background color is set to None for a row type.
	///</summary>
	public class GetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColorNone(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "D9BD1E32-8FA8-4864-968A-3D0F7CE1901F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the background color is set to None for row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the background color is set to None for row types.
	///</summary>
	public class SetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColorNone(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "049E1F90-466B-4A14-B2B5-1E7146740075", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid lineweight value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the grid lineweight value for a grid linetype and row type.
	///</summary>
	public class GetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "07336E5C-C53B-4B97-9F27-A4C682EC7699", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid lineweight value for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the grid lineweight value for grid linetypes and row types.
	///</summary>
	public class SetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E7806C0-4511-427D-BC68-B853AD5827A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid color value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the grid color value for a grid linetype and row type.
	///</summary>
	public class GetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "83954C6A-3170-4198-97B1-0FBE80E317F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid color value for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the grid color value for grid linetypes and row types.
	///</summary>
	public class SetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D1552A2F-BDC6-4985-9B2A-EB315889475D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the grid is visible for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns whether the grid is visible for a grid linetype and row type.
	///</summary>
	public class GetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "2027472A-7E8C-4B68-BEAD-486438853894", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the grid is visible for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the grid is visible for grid linetypes and row types.
	///</summary>
	public class SetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7CA0BF8C-B2EC-451F-8AB1-D74339FF1CB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the data type and unit type of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the data type and unit type of a row type.
	///</summary>
	public class GetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType(((OdaX.AcRowType)inputs[1].Value),((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9AB6D97C-7539-412A-9FFE-C0FA401290F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the data type and unit type of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies the data type and unit type of a row type.
	///</summary>
	public class SetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B4B44452-B4B6-4E74-A555-192F001DA404", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the format of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the format of a row type.
	///</summary>
	public class GetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFormat(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "524BED12-A202-47F7-BE91-AB3A5A987124", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the format of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("val", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies the format of a row type.
	///</summary>
	public class SetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B081B905-2338-4C03-A49B-0D5A07C9E476", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.CreateCellStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "CreateCellStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateCellStyle(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DB97226C-283B-4358-B5B0-F54E6C380BC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.CreateCellStyleFromStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "CreateCellStyleFromStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bstrSourceCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateCellStyleFromStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateCellStyleFromStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3019CE8-FEF4-484E-8C18-1B144A7A5A8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.RenameCellStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "RenameCellStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrOldName", typeof(System.String))]
	[NodeInput("bstrNewName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class RenameCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RenameCellStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2309F933-4409-40BC-AFBA-F69F35A6F7A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.DeleteCellStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "DeleteCellStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class DeleteCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteCellStyle(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7B65879A-D6B7-4898-B9CD-0E1CF08027D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetUniqueCellStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetUniqueCellStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pszBaseName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetUniqueCellStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueCellStyleName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "80FD7425-36A6-41AF-8302-A22A2855D30C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetIsCellStyleInUse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetIsCellStyleInUse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pszCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetIsCellStyleInUse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIsCellStyleInUse(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "212F1CC5-3EA2-4EA3-9148-E84C0962C469", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.NumCellStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "NumCellStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NumCellStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCellStyles);

		}
	}


	[NVP_Manifest(
		Id = "E8ADC508-C23C-4E26-974E-E92D323169E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetCellStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetCellStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("cellStylesArray", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetCellStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCellStyles(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D89F22A1-7F82-4818-B932-DE353266B11A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetTextStyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetTextStyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text style name for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the text style name for the specified cellStyle.
	///</summary>
	public class GetTextStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyleId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "536F534E-E572-4572-9325-D48368EE9565", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetTextStyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetTextStyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text style name for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Sets the text style name for the specified cellStyle.
	///</summary>
	public class SetTextStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyleId(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2F1A0E37-231D-4E4C-82BB-CDB33C6CD9DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetTextHeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetTextHeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text height for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the text height for the specified cellStyle.
	///</summary>
	public class GetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7E42E9A7-DCF6-43F7-B318-14B7C5299DF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetTextHeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetTextHeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text height for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Sets the text height for the specified cellStyle.
	///</summary>
	public class SetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8701105B-0272-4049-9DC5-8B337FC32A74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetAlignment2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetAlignment2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the cell alignment for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the cell alignment for the specified cellStyle.
	///</summary>
	public class GetAlignment2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAlignment2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E392408D-778F-4A38-BE59-EB8596E03A83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetAlignment2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetAlignment2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the cell alignment for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Sets the cell alignment for the specified cellStyle.
	///</summary>
	public class SetAlignment2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAlignment2(inputs[1].Value,((OdaX.AcCellAlignment)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4BE3FD25-79FF-46D1-9B19-B3579DEE57C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the true color value for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the true color value for the specified cellStyle.
	///</summary>
	public class GetColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColor2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "9A043579-2BF8-4ACD-B92E-69BD34D5AA5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the true color value for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Sets the true color value for the specified cellStyle.
	///</summary>
	public class SetColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColor2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "77623B13-E86F-4F27-85C3-3DC3057FD569", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetBackgroundColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetBackgroundColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the background true color value for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the background true color value for the specified cellStyle.
	///</summary>
	public class GetBackgroundColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColor2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E235ACA0-BA5D-42C6-98BF-F3F1996829A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetBackgroundColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetBackgroundColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the background true color value for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Sets the background true color value for the specified cellStyle.
	///</summary>
	public class SetBackgroundColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColor2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B77A384A-9C7B-4711-BF70-C86F300719EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetDataType2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetDataType2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the data type and unit type for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Returns the data type and unit type for the specifed cellStyle.
	///</summary>
	public class GetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType2(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "27AE4D6E-3524-47CF-B4B4-88E88C5A10D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetDataType2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetDataType2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the data type and unit type for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Sets the data type and unit type for the specifed cellStyle.
	///</summary>
	public class SetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType2(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "30BF5FE7-5514-4C16-8A5D-E8142E61B20B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetFormat2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetFormat2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the format for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("pbstrFormat", typeof(System.String))]

	///<summary>
	///Returns the format for the specifed cellStyle.
	///</summary>
	public class GetFormat2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFormat2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5000171-B389-4E8E-9B1D-50B0B1E351B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetFormat2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetFormat2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the format for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bstrFormat", typeof(System.String))]

	///<summary>
	///Sets the format for the specifed cellStyle.
	///</summary>
	public class SetFormat2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6266D8BE-12D6-4CFA-9AF7-D43446E7C0A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetCellClass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetCellClass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetCellClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellClass(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F62606E7-54FC-42BE-B2FF-CE4DEB341E26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetCellClass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetCellClass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("cellClass", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetCellClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellClass(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "87F2772A-7F4C-4F2C-AF8A-A081CC2903EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRotation(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "B27C6CA8-CEC6-4414-9B0B-2B3E0002438C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("Rotation", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRotation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "553D07A2-2278-424F-9A52-28358915378F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetIsMergeAllEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetIsMergeAllEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetIsMergeAllEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIsMergeAllEnabled(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "34FD96AC-DA3E-4109-A2ED-2D54A6F6625A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.EnableMergeAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "EnableMergeAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bEnable", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class EnableMergeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableMergeAll(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "657CCCF3-C584-4D99-9F34-D1F3F0EB8118", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridLineWeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridLineWeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "s) and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///s) and cellStyle.
	///</summary>
	public class GetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "1FD645F7-71F0-4ECD-858A-8A20E693A40B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridLineWeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridLineWeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "s) and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///s) and cellStyle.
	///</summary>
	public class SetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6F0C8E9-EA42-4EF9-89C5-23656A44FC50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the gridColor value for the specified gridLineType and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridColor value for the specified gridLineType and cellStyle.
	///</summary>
	public class GetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "5CCEB9A0-437D-498D-821D-1822C095E57C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the gridColor value for the specified gridLineType and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Sets the gridColor value for the specified gridLineType and cellStyle.
	///</summary>
	public class SetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42155B67-1427-4805-9E30-12BF39583FE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.GetGridVisibility2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "GetGridVisibility2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the gridVisibility value for the specified gridLineType and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridVisibility value for the specified gridLineType and cellStyle.
	///</summary>
	public class GetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "35C6FE22-D73A-45F1-8F21-30D5E814991B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetGridVisibility2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetGridVisibility2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the gridVisibility value for the specified gridLineType and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Sets the gridVisibility value for the specified gridLineType and cellStyle.
	///</summary>
	public class SetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FD1904E9-C00C-4DF3-902D-250D2809697E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.TemplateId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "TemplateId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TemplateId);

		}
	}


	[NVP_Manifest(
		Id = "B93775F9-5D9F-43AD-A3DF-3B0EF7D03431", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.Set_TemplateId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "Set_TemplateId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_TemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TemplateId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FCA463F6-5E76-44F4-8984-3C46C9749A21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTableStyle.SetTemplateId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTableStyle", 
		NodeName = "SetTemplateId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetTemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTemplateId(inputs[1].Value);
			return null;
		}
	}
}
