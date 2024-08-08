using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object that specifies the settings for the current TeighaX drawing
///</summary>
namespace OdaX.AcadDatabasePreferences 
{

	[NVP_Manifest(
		Id = "42011372-ACA9-414A-9050-353E7E020556", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.AcadDatabasePreferences_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "_AcadDatabasePreferences_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabasePreferences_Constructor : INode 
	{
		public OdaX.IAcadDatabasePreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDatabasePreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C16AA159-3B45-49F2-8DF4-2115EAACAED9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.AcadDatabasePreferences_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "_AcadDatabasePreferences_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabasePreferences_ConstructorCast : INode 
	{
		public OdaX.IAcadDatabasePreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDatabasePreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FE068F83-5112-440A-ACDD-8D1FBB7B327B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "268651C9-EE2D-4DE1-A96B-84E0C67C2512", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.SolidFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "SolidFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether certain objects in a document are filled in.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether certain objects in a document are filled in.
	///</summary>
	public class SolidFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SolidFill);

		}
	}


	[NVP_Manifest(
		Id = "B056F01B-0B76-42E1-BCD3-6450DF6E6CD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_SolidFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_SolidFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether certain objects in a document are filled in.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Fill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether certain objects in a document are filled in.
	///</summary>
	public class Set_SolidFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SolidFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93DE3DA3-0D14-408A-909B-ABE733695EC7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.XRefEdit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "XRefEdit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a document can be edited when it is used as an external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether a document can be edited when it is used as an external reference.
	///</summary>
	public class XRefEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefEdit);

		}
	}


	[NVP_Manifest(
		Id = "48A019ED-E2E0-4427-A74E-E3911EEC6A39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_XRefEdit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_XRefEdit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a document can be edited when it is used as an external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Edit", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a document can be edited when it is used as an external reference.
	///</summary>
	public class Set_XRefEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefEdit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C663F574-90E5-4FE6-9BDD-E2A7265709F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.XRefLayerVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "XRefLayerVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether changes to layers and paths of an external reference are saved with the document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
	///</summary>
	public class XRefLayerVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefLayerVisibility);

		}
	}


	[NVP_Manifest(
		Id = "A8DB96D8-74EE-4F15-8E98-ABCA67341445", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_XRefLayerVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_XRefLayerVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether changes to layers and paths of an external reference are saved with the document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("XRefLayerVis", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
	///</summary>
	public class Set_XRefLayerVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefLayerVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1EE1DF01-F6AE-49E5-BA0D-D932656F0429", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.OLELaunch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "OLELaunch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
	///</summary>
	public class OLELaunch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OLELaunch);

		}
	}


	[NVP_Manifest(
		Id = "40A0D260-4F77-4091-BC19-FF1FFFEA1890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_OLELaunch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_OLELaunch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Launch", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
	///</summary>
	public class Set_OLELaunch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OLELaunch = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9A03EF9A-F405-4283-8810-0906CA643B2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.AllowLongSymbolNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "AllowLongSymbolNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether symbol names can include extended characters.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether symbol names can include extended characters.
	///</summary>
	public class AllowLongSymbolNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowLongSymbolNames);

		}
	}


	[NVP_Manifest(
		Id = "86A3CAC8-FA1C-4BD9-9B3F-293AEAE7F4AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_AllowLongSymbolNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_AllowLongSymbolNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether symbol names can include extended characters.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("LongNames", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether symbol names can include extended characters.
	///</summary>
	public class Set_AllowLongSymbolNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowLongSymbolNames = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA93A553-401E-4FA9-B773-7D92E3BD6587", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortBySelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortBySelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by entity selection.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by entity selection.
	///</summary>
	public class ObjectSortBySelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortBySelection);

		}
	}


	[NVP_Manifest(
		Id = "C28846F2-8A10-4B73-BB5E-84FF405D1E51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortBySelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortBySelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by entity selection.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by entity selection.
	///</summary>
	public class Set_ObjectSortBySelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortBySelection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0DFBF795-C526-4446-8DF3-CD2CD15FD7CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortBySnap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortBySnap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by object snap.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by object snap.
	///</summary>
	public class ObjectSortBySnap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortBySnap);

		}
	}


	[NVP_Manifest(
		Id = "5A8CFECA-5049-443F-A167-1BC734FDE526", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortBySnap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortBySnap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by object snap.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by object snap.
	///</summary>
	public class Set_ObjectSortBySnap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortBySnap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "187D5BED-4193-4F16-AD27-C25E0120DDA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortByRedraws", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortByRedraws", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by redraw order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by redraw order.
	///</summary>
	public class ObjectSortByRedraws : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByRedraws);

		}
	}


	[NVP_Manifest(
		Id = "CC9CB325-3B24-4E45-800E-20D5D71403C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortByRedraws", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortByRedraws", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by redraw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by redraw order.
	///</summary>
	public class Set_ObjectSortByRedraws : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByRedraws = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E3D319D4-A9EF-46D7-BF30-3AFC9828EFAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortByRegens", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortByRegens", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by regeneration order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by regeneration order.
	///</summary>
	public class ObjectSortByRegens : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByRegens);

		}
	}


	[NVP_Manifest(
		Id = "103F6F45-EE6D-4487-873E-BCC0D3542CF8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortByRegens", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortByRegens", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by regeneration order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by regeneration order.
	///</summary>
	public class Set_ObjectSortByRegens : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByRegens = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "12C91D6A-1600-4E96-9D9F-1C8E144CA997", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortByPlotting", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortByPlotting", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by printing order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by printing order.
	///</summary>
	public class ObjectSortByPlotting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByPlotting);

		}
	}


	[NVP_Manifest(
		Id = "CA618317-EC9D-4EEB-BECB-B2B98475297F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortByPlotting", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortByPlotting", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by printing order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by printing order.
	///</summary>
	public class Set_ObjectSortByPlotting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByPlotting = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A9A2A2B2-C7E6-4AA7-935C-6FB86FC22283", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ObjectSortByPSOutput", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ObjectSortByPSOutput", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by PostScript output order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by PostScript output order.
	///</summary>
	public class ObjectSortByPSOutput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByPSOutput);

		}
	}


	[NVP_Manifest(
		Id = "0E9B4C02-C97D-42EB-9535-C90686AACDDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ObjectSortByPSOutput", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ObjectSortByPSOutput", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects are sorted by PostScript output order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by PostScript output order.
	///</summary>
	public class Set_ObjectSortByPSOutput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByPSOutput = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E7C853B-9FC2-405E-87C7-7ABE4B851921", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_ContourLinesPerSurface", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_ContourLinesPerSurface", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of isolines per surface for objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of isolines per surface for objects.
	///</summary>
	public class Set_ContourLinesPerSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContourLinesPerSurface = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64F88B0C-DA20-4E3C-BC37-E04F4ADF5836", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.ContourLinesPerSurface", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "ContourLinesPerSurface", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of isolines per surface for objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the number of isolines per surface for objects.
	///</summary>
	public class ContourLinesPerSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContourLinesPerSurface);

		}
	}


	[NVP_Manifest(
		Id = "0C882EA7-F5EE-4D70-92C4-1727D5E02F09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_DisplaySilhouette", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_DisplaySilhouette", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether silhouette curves of 3D solids display in wireframe view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
	///</summary>
	public class Set_DisplaySilhouette : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplaySilhouette = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "77BB6382-74FE-4335-9657-060DDA73878B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.DisplaySilhouette", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "DisplaySilhouette", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether silhouette curves of 3D solids display in wireframe view.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
	///</summary>
	public class DisplaySilhouette : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplaySilhouette);

		}
	}


	[NVP_Manifest(
		Id = "43F01F74-CD8A-4F33-A056-FF74871D0032", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_MaxActiveViewports", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_MaxActiveViewports", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the maximum number of active viewports allowed in a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the maximum number of active viewports allowed in a document.
	///</summary>
	public class Set_MaxActiveViewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxActiveViewports = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4D62E582-AAE5-41A4-AC46-0B096E06203A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.MaxActiveViewports", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "MaxActiveViewports", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the maximum number of active viewports allowed in a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the maximum number of active viewports allowed in a document.
	///</summary>
	public class MaxActiveViewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxActiveViewports);

		}
	}


	[NVP_Manifest(
		Id = "1D06657B-246A-464E-8DC6-2838B11864D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_RenderSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_RenderSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the quality of hidden, shaded, and rendered objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Double))]

	///<summary>
	///Specifies or returns the quality of hidden, shaded, and rendered objects.
	///</summary>
	public class Set_RenderSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RenderSmoothness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4575978F-E14C-4FB3-B942-CC1CCEFA83A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.RenderSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "RenderSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the quality of hidden, shaded, and rendered objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the quality of hidden, shaded, and rendered objects.
	///</summary>
	public class RenderSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RenderSmoothness);

		}
	}


	[NVP_Manifest(
		Id = "76B4F2DC-0E55-46C2-B507-EE0BD3822E92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_SegmentPerPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_SegmentPerPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of line segments generated for polylines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of line segments generated for polylines.
	///</summary>
	public class Set_SegmentPerPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SegmentPerPolyline = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AD771AA-BC8D-4D29-AEBD-9270A29D0289", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.SegmentPerPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "SegmentPerPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of line segments generated for polylines.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the number of line segments generated for polylines.
	///</summary>
	public class SegmentPerPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegmentPerPolyline);

		}
	}


	[NVP_Manifest(
		Id = "C02118F3-7DC0-416C-B207-978F909032C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_TextFrameDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_TextFrameDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether text frames display instead of text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether text frames display instead of text.
	///</summary>
	public class Set_TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFrameDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "148CC465-EF64-4B75-9F9D-209C37E8FB6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.TextFrameDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "TextFrameDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether text frames display instead of text.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether text frames display instead of text.
	///</summary>
	public class TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFrameDisplay);

		}
	}


	[NVP_Manifest(
		Id = "D7556360-12B1-4569-811B-B93540F1F205", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the default lineweight for a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("OdaX.AcLineWeight", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the default lineweight for a document.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = ((OdaX.AcLineWeight)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6C554ED-3612-4F16-8F3B-2F2C76987141", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the default lineweight for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the default lineweight for a document.
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
		Id = "E2F93FA3-C108-4992-968D-299B2211F7AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.Set_LineWeightDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "Set_LineWeightDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether lineweights display in a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether lineweights display in a document.
	///</summary>
	public class Set_LineWeightDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F209FCAA-AEEB-4290-9AEA-670CA7611714", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabasePreferences.LineWeightDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabasePreferences", 
		NodeName = "LineWeightDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether lineweights display in a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether lineweights display in a document.
	///</summary>
	public class LineWeightDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightDisplay);

		}
	}
}
