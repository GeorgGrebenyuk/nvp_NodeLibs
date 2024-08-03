using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a named collection of plot settings
///</summary>
namespace OdaX.AcadPlotConfiguration 
{

	[NVP_Manifest(
		Id = "679CBACE-7F6D-4A1B-9A82-A8C52779161F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.AcadPlotConfiguration_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "_AcadPlotConfiguration_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfiguration_Constructor : INode 
	{
		public OdaX.IAcadPlotConfiguration _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPlotConfiguration;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "51396B69-D0B6-4841-9CF1-7806827A10D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.AcadPlotConfiguration_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "_AcadPlotConfiguration_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfiguration_ConstructorCast : INode 
	{
		public OdaX.IAcadPlotConfiguration _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPlotConfiguration;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FBC01BC8-C910-4F56-8F99-FB758C7F24ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the object.
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
		Id = "CE1B1B9D-1A31-4016-9EC3-E50039ABB23F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the object.
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
		Id = "580B1A25-62DB-47E3-A7E1-BEDCC7810F6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.ConfigName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "ConfigName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a plot configuration file.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	public class ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConfigName);

		}
	}


	[NVP_Manifest(
		Id = "23C790F7-3AC9-455A-9395-1AE56BCB01C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_ConfigName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_ConfigName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a plot configuration file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	public class Set_ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConfigName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F806D1CE-34DD-44C2-BB5E-53E444044C2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.CanonicalMediaName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "CanonicalMediaName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the media size.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	public class CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CanonicalMediaName);

		}
	}


	[NVP_Manifest(
		Id = "2307C1FB-73DF-4618-9B55-F33E9E66AD78", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_CanonicalMediaName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_CanonicalMediaName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the media size.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	public class Set_CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CanonicalMediaName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C33F2CF4-F20F-40A3-83D2-4FC6502AE62A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PaperUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PaperUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the units used for plot configuration properties.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	public class PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperUnits);

		}
	}


	[NVP_Manifest(
		Id = "2E04BF0B-96D5-4B09-B493-CE1098BCCF22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PaperUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PaperUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the units used for plot configuration properties.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotPaperUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	public class Set_PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PaperUnits = ((OdaX.AcPlotPaperUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6E4BD6C7-4BD6-4718-93E9-C2D1A29AA333", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotViewportBorders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotViewportBorders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to print the edges of viewports.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	public class PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportBorders);

		}
	}


	[NVP_Manifest(
		Id = "F8F7CC1C-5608-42CB-9683-746813EC9E33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotViewportBorders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotViewportBorders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to print the edges of viewports.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportBorders", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	public class Set_PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportBorders = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "86B15F63-F6AB-4867-A997-7814A2EB2F1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.ShowPlotStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "ShowPlotStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether plot styles are applied when displaying objects on the screen.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	public class ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowPlotStyles);

		}
	}


	[NVP_Manifest(
		Id = "61D86880-9A4C-4D4B-8F29-89041F121BD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_ShowPlotStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_ShowPlotStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether plot styles are applied when displaying objects on the screen.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	public class Set_ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowPlotStyles = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D88BB3BD-73EB-425C-8D66-C8D27324D3E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of the plot configuration.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	public class PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotRotation);

		}
	}


	[NVP_Manifest(
		Id = "E25ED943-006B-4231-A76D-C14CE18BD33D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of the plot configuration.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotRotation", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	public class Set_PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotRotation = ((OdaX.AcPlotRotation)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE6F1DAB-199C-418E-BDE1-027CF0980241", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.CenterPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "CenterPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are centered on the printed media.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	public class CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterPlot);

		}
	}


	[NVP_Manifest(
		Id = "3F492AA3-6973-40B1-B84E-54E1FF91516E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_CenterPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_CenterPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are centered on the printed media.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pCentered", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	public class Set_CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterPlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3AB27D57-58B1-4489-8F3F-7F1956C6EA1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotHidden", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotHidden", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are printed.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	public class PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotHidden);

		}
	}


	[NVP_Manifest(
		Id = "AD58D0C5-41AB-4F25-8069-CF0A510D4725", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotHidden", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotHidden", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are printed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pHidden", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	public class Set_PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotHidden = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "48010CEE-0AA1-4887-AB14-7F0182F2B345", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the method used to determine which objects print.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	public class PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotType);

		}
	}


	[NVP_Manifest(
		Id = "03807035-444E-4ECB-B21A-D74E217A2513", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the method used to determine which objects print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	public class Set_PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotType = ((OdaX.AcPlotType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B88A4DE-D7DE-464F-AABF-D18747C35342", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.ViewToPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "ViewToPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the view to print.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	public class ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewToPlot);

		}
	}


	[NVP_Manifest(
		Id = "247373E1-65AE-4CFC-9CCF-7F9A48607F63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_ViewToPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_ViewToPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the view to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	public class Set_ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewToPlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "41489E50-1309-4C70-84BE-88763EED6D0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.UseStandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "UseStandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to print using a standard scale or custom scale.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	public class UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseStandardScale);

		}
	}


	[NVP_Manifest(
		Id = "0A29639F-6603-4275-B374-E58A1C15034E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_UseStandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_UseStandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to print using a standard scale or custom scale.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pUseStdScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	public class Set_UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseStandardScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6DDC14A1-519E-464A-A713-8A2D611B5554", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.StandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "StandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the standard scale value.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	public class StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale);

		}
	}


	[NVP_Manifest(
		Id = "C0289933-F0E1-4BEC-B5A9-20BF0011A369", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_StandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_StandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the standard scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	public class Set_StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale = ((OdaX.AcPlotScale)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "89603D05-0D07-4CAD-9182-6A636109C493", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetCustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetCustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the custom scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]

	///<summary>
	///Returns the custom scale value.
	///</summary>
	public class GetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomScale(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F2AA824-ACCF-4FE0-A7B9-8E1BD8129C04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.SetCustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "SetCustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the custom scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]

	///<summary>
	///Sets the custom scale value.
	///</summary>
	public class SetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomScale(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A21817C1-77E2-4EDE-A2BB-F925FE1916F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.ScaleLineweights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "ScaleLineweights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether lineweights are scaled during printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	public class ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleLineweights);

		}
	}


	[NVP_Manifest(
		Id = "4803A681-FFED-4526-BCC9-FB87EF809C6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_ScaleLineweights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_ScaleLineweights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether lineweights are scaled during printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	public class Set_ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleLineweights = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FEB1B96-0BCF-46F0-9DFF-089263C0792E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotWithLineweights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotWithLineweights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects print with lineweights.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	public class PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithLineweights);

		}
	}


	[NVP_Manifest(
		Id = "7F404FCB-632E-4A4C-B42E-62B2804C6A00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotWithLineweights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotWithLineweights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects print with lineweights.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlot", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	public class Set_PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithLineweights = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BAE1AC66-F4F2-4E1E-B3C1-1548C79646F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotViewportsFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotViewportsFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects in paperspace print first.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	public class PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportsFirst);

		}
	}


	[NVP_Manifest(
		Id = "C3A8641D-92E0-46DB-9D71-44B4334A7414", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotViewportsFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotViewportsFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects in paperspace print first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportsFirst", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	public class Set_PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportsFirst = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AEB484A3-CAA4-49C7-98A4-15694E6C8EBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.StyleSheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "StyleSheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style sheet used for printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	public class StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleSheet);

		}
	}


	[NVP_Manifest(
		Id = "DCA310D1-633C-4B8D-9CA2-1492D3E151F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_StyleSheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_StyleSheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style sheet used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	public class Set_StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleSheet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C340620B-E15D-4DEE-87F5-A9DECE55A939", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetPaperMargins", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetPaperMargins", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the margins used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Returns the margins used for printing.
	///</summary>
	public class GetPaperMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperMargins(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "94067308-D56D-4E28-88DE-3BCE6C51CA3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetPaperSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetPaperSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the width and height of the specified media.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Returns the width and height of the specified media.
	///</summary>
	public class GetPaperSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperSize(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "054EAAD8-0D63-40F1-BAA0-4076DB7E49F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the origin point used for printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	public class PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotOrigin);

		}
	}


	[NVP_Manifest(
		Id = "5A08FD0E-2049-4ECE-8C5C-F9096E2B4A1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the origin point used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pOrigin", typeof(System.Object))]

	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	public class Set_PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotOrigin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AE45EF9-A799-479D-B5C5-B6189BF81C0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetWindowToPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetWindowToPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the coordinates that define the area to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Returns the coordinates that define the area to print.
	///</summary>
	public class GetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWindowToPlot(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B52DD791-AB39-42F7-A6B5-42E78B133A6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.SetWindowToPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "SetWindowToPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the coordinates that define the area to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Sets the coordinates that define the area to print.
	///</summary>
	public class SetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWindowToPlot(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F83A36C4-5397-44DC-9439-ACFABA407330", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.PlotWithPlotStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "PlotWithPlotStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	public class PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithPlotStyles);

		}
	}


	[NVP_Manifest(
		Id = "C9BEED0A-F652-467A-8323-3FCE56F25B83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.Set_PlotWithPlotStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "Set_PlotWithPlotStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	public class Set_PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithPlotStyles = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A009ACA2-3BE4-4C5B-9E4C-C4B085A53433", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.ModelType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "ModelType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the settings apply to objects in a modelspace layout only or both modelspace and paperspace layouts.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns whether the settings apply to objects in a modelspace layout only or both modelspace and paperspace layouts.
	///</summary>
	public class ModelType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelType);

		}
	}


	[NVP_Manifest(
		Id = "E991C808-25C5-4150-8C0D-775C4A8875D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.CopyFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "CopyFrom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Copies settings from a plot configuration file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlotConfig", typeof(System.Object))]

	///<summary>
	///Copies settings from a plot configuration file.
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AE04A939-2953-45EB-8C94-122D2CFA72A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetCanonicalMediaNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetCanonicalMediaNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns names of the media available for a print device.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns names of the media available for a print device.
	///</summary>
	public class GetCanonicalMediaNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCanonicalMediaNames);

		}
	}


	[NVP_Manifest(
		Id = "7EF399A4-8D28-4660-854A-921141718B97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetPlotDeviceNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetPlotDeviceNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns print device names.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns print device names.
	///</summary>
	public class GetPlotDeviceNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotDeviceNames);

		}
	}


	[NVP_Manifest(
		Id = "9083F62F-847A-43CB-9B3B-7F3D0F844DD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetPlotStyleTableNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetPlotStyleTableNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns plot style table names.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns plot style table names.
	///</summary>
	public class GetPlotStyleTableNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotStyleTableNames);

		}
	}


	[NVP_Manifest(
		Id = "ADD7131F-FC4F-4411-A7ED-542EC43C7628", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.RefreshPlotDeviceInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "RefreshPlotDeviceInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates print device information with the current settings.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Updates print device information with the current settings.
	///</summary>
	public class RefreshPlotDeviceInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RefreshPlotDeviceInfo();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C64E2FE-650D-4045-9EA5-FEDA1140C542", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPlotConfiguration.GetLocaleMediaName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPlotConfiguration", 
		NodeName = "GetLocaleMediaName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the localized version of a media name.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Returns the localized version of a media name.
	///</summary>
	public class GetLocaleMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLocaleMediaName(inputs[1].Value));

		}
	}
}
