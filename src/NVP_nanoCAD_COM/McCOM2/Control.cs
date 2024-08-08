using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IControl interface
///</summary>
namespace McCOM2.Control 
{

	[NVP_Manifest(
		Id = "3246054A-D4F6-41EF-B91D-00F8BCFEE90A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Control_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "_Control_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Control_Constructor : INode 
	{
		public McCOM2.IControl _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IControl;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3036B1DF-D9E0-4B5C-8900-B84C7FE403BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Control_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "_Control_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Control_ConstructorCast : INode 
	{
		public McCOM2.IControl _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IControl;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4D5A317A-EDFD-4B85-8B54-AD5F8215103D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d9", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005d9
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "F541554A-5236-4454-BFC3-617BBB21E6FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d9", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000005d9
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "743451C1-880A-43AC-9D66-335810D5E97B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.ClassName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "ClassName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005da", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005da
	///</summary>
	public class ClassName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClassName);

		}
	}


	[NVP_Manifest(
		Id = "F8DF1B61-DD9A-4AA6-B1D1-184E454EC2B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005db", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005db
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
		Id = "8A6787AD-94AC-437D-AEBD-5427A216FFC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005dc", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005dc
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
		Id = "68171176-9586-4492-8D87-9C91916CAC3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005dc", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005dc
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
		Id = "373E10C1-AA95-4E3A-8096-7462B7D0D25A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

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
		Id = "276B21A6-0D38-41F5-B845-7F35064CC92A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

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
		Id = "A2842524-B252-4BCF-9BE8-6F81A69F44B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Form", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Form", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ef", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005ef
	///</summary>
	public class Form : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Form);

		}
	}


	[NVP_Manifest(
		Id = "16778F51-33CD-47F2-B447-4A31943AE4C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Left", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Left", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005df", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005df
	///</summary>
	public class Left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Left);

		}
	}


	[NVP_Manifest(
		Id = "46446FAF-D498-43C6-8BFD-E4530E8F2832", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Left", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Left", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005df", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005df
	///</summary>
	public class Set_Left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Left = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8DC0ECFF-1E57-4C8A-ABBB-A3796AC53001", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Top", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Top", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e0", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e0
	///</summary>
	public class Top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Top);

		}
	}


	[NVP_Manifest(
		Id = "68E90BD2-E5E4-4D28-8463-87DFFD6B3FDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Top", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Top", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e0", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e0
	///</summary>
	public class Set_Top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Top = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A2C1D86C-D1A8-46C4-96A3-5329897D0A5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Right", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Right", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e1", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e1
	///</summary>
	public class Right : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Right);

		}
	}


	[NVP_Manifest(
		Id = "7E820F0C-D53C-42DA-89B7-82FFCA3616AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Right", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Right", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e1", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e1
	///</summary>
	public class Set_Right : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Right = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58158126-E39E-4ADA-BD88-76CE80546F8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Bottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Bottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e2", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e2
	///</summary>
	public class Bottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bottom);

		}
	}


	[NVP_Manifest(
		Id = "C645C7AC-50B4-4129-9B43-9BEAEEC29BFA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Bottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Bottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e2", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e2
	///</summary>
	public class Set_Bottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74A9CE68-1C7B-41E0-8D83-30BCF4D2EABF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e3", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e3
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "7BB32A18-CAF0-4C4B-B52C-F4B4EC6B310E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e3", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e3
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF161942-27A9-4FB2-B3BD-49A73A682EE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e4", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e4
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "1DDD4C4E-FBA3-4D08-9FD8-88D72253EBED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Control.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Control", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e4", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e4
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}
}
