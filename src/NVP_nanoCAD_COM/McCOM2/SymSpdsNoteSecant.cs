using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteSecant interface
///</summary>
namespace McCOM2.SymSpdsNoteSecant 
{

	[NVP_Manifest(
		Id = "3702A609-B3BA-4ADF-936C-6BF0852F843E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.SymSpdsNoteSecant_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "_SymSpdsNoteSecant_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteSecant_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteSecant _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteSecant;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B0AE1DC0-2C2C-453F-BEF4-EC6772B00E0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.SymSpdsNoteSecant_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "_SymSpdsNoteSecant_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteSecant_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteSecant _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteSecant;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D2F8CA9A-3D0E-44E8-8941-73B2D87AC77C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045c
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
		Id = "487353B9-99B2-4CC1-800D-EA2A1B52A707", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000045c
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
		Id = "DDA123F1-2662-4E3F-BF71-63D2A8BB4D23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000449", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000449
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align);

		}
	}


	[NVP_Manifest(
		Id = "4A3C8DAD-EAF7-4660-9B88-C03FCD3A2837", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000449", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000449
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE854170-443C-4A0A-B685-CFBD65860767", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045b
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Start);

		}
	}


	[NVP_Manifest(
		Id = "89649DF1-8425-427D-958E-A0DDE5F5BEBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000045b
	///</summary>
	public class Set_Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82F47964-2012-44E9-B811-7A65BBECF2A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000044f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000044f
	///</summary>
	public class End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.End);

		}
	}


	[NVP_Manifest(
		Id = "89465195-C5B6-47E6-BFEF-67DD62E52331", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000044f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000044f
	///</summary>
	public class Set_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7873EBE-5C88-4164-ABF9-F06C30699781", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000044e", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000044e
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
		Id = "36426842-AFC2-4C0A-8FD1-7C714733966E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000044e", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x0000044e
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
		Id = "F495F028-9704-4AB2-A267-339A0CDF4EE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000452", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000452
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Id = "163915B9-0598-45B4-ABBD-830C38E95143", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000452", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000452
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A8C2A7D1-C432-4DDC-A04B-54404B99DD69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000450", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000450
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Id = "CC45DD04-BC85-432B-985C-02CBF5D4820A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000450", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000450
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E9DE199-0BD0-499C-A150-B30A8BD19F52", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045a
	///</summary>
	public class Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sheet);

		}
	}


	[NVP_Manifest(
		Id = "49705413-CCCB-4ADF-8C43-B3A26AAB9095", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteSecant.Set_Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteSecant", 
		NodeName = "Set_Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000045a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000045a
	///</summary>
	public class Set_Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sheet = inputs[1].Value;
			return null;
		}
	}
}
