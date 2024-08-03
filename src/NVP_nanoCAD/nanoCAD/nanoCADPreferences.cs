using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.nanoCADPreferences 
{

	[NVP_Manifest(
		Id = "B732EBF3-1528-4B99-87B6-8973A124BA73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.nanoCADPreferences_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "_nanoCADPreferences_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferences_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DD6FDBAB-69F0-42B0-8FA3-3739C675831B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.nanoCADPreferences_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "_nanoCADPreferences_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferences_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E4D42637-EF10-4DA9-869A-2A3D6F6310D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

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
		Id = "015A2042-2112-44B5-8B38-ACA5DC26E456", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Files", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Files", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesFiles object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesFiles object.
	///</summary>
	public class Files : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Files);

		}
	}


	[NVP_Manifest(
		Id = "1C2523B7-7F5D-494E-ABCE-61C3AC982970", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Display", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Display", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesDisplay object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesDisplay object.
	///</summary>
	public class Display : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Display);

		}
	}


	[NVP_Manifest(
		Id = "F6381B1B-753E-46B8-8791-2E11A2036C88", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.OpenSave", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "OpenSave", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesOpenSave object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesOpenSave object.
	///</summary>
	public class OpenSave : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenSave);

		}
	}


	[NVP_Manifest(
		Id = "417F7601-5E52-4F8C-AE2E-A9CAA7F900A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Output", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Output", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesOutput object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesOutput object.
	///</summary>
	public class Output : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Output);

		}
	}


	[NVP_Manifest(
		Id = "02D74FBA-EA7C-481E-BD4B-450AC014662E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.System", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "System", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesSystem object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesSystem object.
	///</summary>
	public class System : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.System);

		}
	}


	[NVP_Manifest(
		Id = "1A1FCB2B-FAA5-4BD7-8C0A-A790DB503070", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.User", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "User", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesUser object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesUser object.
	///</summary>
	public class User : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.User);

		}
	}


	[NVP_Manifest(
		Id = "01A77F9C-E9BC-452D-8835-F9E64AFA9C24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Drafting", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Drafting", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesDrafting object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesDrafting object.
	///</summary>
	public class Drafting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Drafting);

		}
	}


	[NVP_Manifest(
		Id = "228DB35F-CB19-4D24-B1A0-1EA501ED42DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Selection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Selection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesSelection object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesSelection object.
	///</summary>
	public class Selection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Selection);

		}
	}


	[NVP_Manifest(
		Id = "ACE63F1D-863C-4BA0-9959-2F95F8FFDF67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferences.Profiles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferences", 
		NodeName = "Profiles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PreferencesProfiles object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesProfiles object.
	///</summary>
	public class Profiles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profiles);

		}
	}
}
