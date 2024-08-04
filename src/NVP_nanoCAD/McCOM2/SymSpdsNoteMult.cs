using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteMult interface
///</summary>
namespace McCOM2.SymSpdsNoteMult 
{

	[NVP_Manifest(
		Id = "E2B5EB54-07A0-436D-98FD-B3C1B4871377", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.SymSpdsNoteMult_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "_SymSpdsNoteMult_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteMult_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteMult _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteMult;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6F575EF0-AC97-4E60-BD0A-E8E3B1DB1F9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.SymSpdsNoteMult_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "_SymSpdsNoteMult_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteMult_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteMult _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteMult;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AEA0DF0F-2533-4088-9327-78660E14CFD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000421", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000421
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "D3A777A5-23F6-4A6B-BCDB-230ABF35D9D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000421", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000421
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E384B1D9-313B-4566-8D3E-9BD1A2FB261F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000424", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000424
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Id = "73799582-40F6-4754-8317-C4BEF4CE9F8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000424", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000424
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2BAF6819-1CF5-439E-9294-0F82E9681E54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000410", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000410
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Id = "DD648A8A-AB3E-47EA-94C4-35C73F1D42DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000410", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000410
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83A3DE22-5DD3-42AB-A72E-FF44863BE1A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000423", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000423
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Id = "D348AE10-888C-4EA8-AE13-912D76C7EC81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000423", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x00000423
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "57171106-FEFB-4198-8FE6-647DCBAF7170", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Lines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Lines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000041a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000041a
	///</summary>
	public class Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lines(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "EC4F436D-8FCE-4186-AD7D-20E0B317B60F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Lines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Lines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000041a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x0000041a
	///</summary>
	public class Set_Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lines[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "76866D27-7387-4CE5-9C6D-CE8136D64FE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.LinesCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "LinesCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000041b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x0000041b
	///</summary>
	public class LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinesCount);

		}
	}


	[NVP_Manifest(
		Id = "C4CF56C5-9FF6-4127-B237-061AF18DCC28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_LinesCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_LinesCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000041b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000041b
	///</summary>
	public class Set_LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinesCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BA0D02D1-D35B-468B-A3C9-7D2AF96112C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000040f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000040f
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4073FDE8-B2B5-49A1-BD96-85A74D29AEF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000040f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x0000040f
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BCC8F96-9AC3-4168-BD2D-B109A8A66DC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000415", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000415
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "7803682C-E679-46F7-839B-C8744BC499B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000415", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000415
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF16F3FD-BD7B-4FAD-89CE-E2BF85070F4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Grow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Grow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000416", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000416
	///</summary>
	public class Grow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Grow);

		}
	}


	[NVP_Manifest(
		Id = "8C42B91D-50B7-4830-BD6B-A20A73BAA75C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Grow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Grow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000416", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000416
	///</summary>
	public class Set_Grow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Grow = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "05ACB7D0-C825-419F-9453-3D9CE84646E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Line", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Line", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000419", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000419
	///</summary>
	public class Line : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Line);

		}
	}


	[NVP_Manifest(
		Id = "2A996F7B-F3F5-4DA7-84AC-FD217561507A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteMult.Set_Line", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteMult", 
		NodeName = "Set_Line", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000419", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000419
	///</summary>
	public class Set_Line : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Line = inputs[1].Value;
			return null;
		}
	}
}
