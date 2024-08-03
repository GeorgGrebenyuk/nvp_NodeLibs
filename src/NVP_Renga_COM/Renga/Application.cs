using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Application 
{

	[NVP_Manifest(
		Id = "5F078AC4-6A60-417B-87B6-5096DF14CBDE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Application_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "_Application_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Application_Constructor : INode 
	{
		public Renga.IApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CB54B4E5-09CF-4E87-BB45-374B636EFDB6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Application_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "_Application_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Application_ConstructorCast : INode 
	{
		public Renga.IApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "712D39FF-CF0E-4BBF-969A-FBDF325DDD61", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Enable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Enable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enable();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E7D4B4E-0F81-4F92-9768-7DC36EAEAFA1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Disable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Disable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Disable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Disable();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "949FC523-761C-4D72-88DF-54621C14B749", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Set_Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Set_Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("pEnabled", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "552A6352-75DF-4745-9AE0-D21C578ABBF7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Id = "E4D139DF-3655-4ABB-9ECF-FD7634E119B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.GetMainWindowHandle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "GetMainWindowHandle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetMainWindowHandle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMainWindowHandle);

		}
	}


	[NVP_Manifest(
		Id = "8AD7BFD1-D8BC-48EE-82EA-3E891DBEAB0C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.ActiveView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "ActiveView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ActiveView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveView);

		}
	}


	[NVP_Manifest(
		Id = "54A4ED6C-818E-41F4-88AB-0B6D4A909351", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.UI", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "UI", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UI);

		}
	}


	[NVP_Manifest(
		Id = "D4FEB59F-CFDD-47F6-86C1-B3A4ABC5ED78", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.HasProject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "HasProject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasProject);

		}
	}


	[NVP_Manifest(
		Id = "C4F2EDD8-EA0D-45D5-9ECE-454CA4724918", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Project", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Project", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Project : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Project);

		}
	}


	[NVP_Manifest(
		Id = "89439D2E-E3B2-455C-AB43-C8DF2204729C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Selection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Selection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
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
		Id = "B6704CA2-05C5-4CAB-8692-7B22625A4C47", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.GetCurrentLocale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "GetCurrentLocale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCurrentLocale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCurrentLocale);

		}
	}


	[NVP_Manifest(
		Id = "02C2932E-9ACD-4277-B167-87ED159F4C35", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.CreateProject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "CreateProject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateProject);

		}
	}


	[NVP_Manifest(
		Id = "AF05BA93-A3C3-4E79-BBC2-032F4A07ECAE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.CreateProjectFromTemplate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "CreateProjectFromTemplate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateProjectFromTemplate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateProjectFromTemplate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "A5D84424-639E-4CFD-80FF-9AF9B10F22E6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.ImportIfcProject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "ImportIfcProject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ImportIfcProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImportIfcProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5775559B-82D1-423D-A16F-E47BCD75A850", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.OpenProject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "OpenProject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OpenProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "A82D4696-CC07-4183-939E-92BA5BC5674B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.CloseProject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "CloseProject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("discardChanges", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CloseProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CloseProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "220072E0-4D41-448C-BEC8-D85A8C2444CB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Quit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Quit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Quit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quit();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "05641778-428D-4E8F-A2C1-01AAD0D44894", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Id = "1D4F32B9-4E0A-47DC-BE05-A1D6195426F3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("pVisible", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6F3022C3-007B-4623-A3D4-3898B30A6E5A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.CreateIfcExportSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "CreateIfcExportSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateIfcExportSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateIfcExportSettings);

		}
	}


	[NVP_Manifest(
		Id = "F0F4F336-3BEB-41AC-AA0C-6A811A3464F5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Application.Version", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Application", 
		NodeName = "Version", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}
}
