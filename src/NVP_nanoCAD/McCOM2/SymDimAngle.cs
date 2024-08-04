using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Angle dimension
///</summary>
namespace McCOM2.SymDimAngle 
{

	[NVP_Manifest(
		Id = "D9543573-B461-45AF-A987-BE853AC66DC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.SymDimAngle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "_SymDimAngle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimAngle_Constructor : INode 
	{
		public McCOM2.ISymDimAngle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimAngle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "72DE33F8-356D-4C9D-A133-B6ABE0323EF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.SymDimAngle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "_SymDimAngle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimAngle_ConstructorCast : INode 
	{
		public McCOM2.ISymDimAngle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimAngle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "652F9291-0386-4120-B795-07D1388ADE0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000582", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000582
	///</summary>
	public class Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position1);

		}
	}


	[NVP_Manifest(
		Id = "01EBE3AC-56CF-4F75-91D2-6CA2072A4031", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000582", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000582
	///</summary>
	public class Set_Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B1071D55-D9AF-48E7-836C-E731A43D38BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000583", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000583
	///</summary>
	public class Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position2);

		}
	}


	[NVP_Manifest(
		Id = "57A9F07D-DE8A-43B0-9983-56F70159758B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000583", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000583
	///</summary>
	public class Set_Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7F062187-8B72-468C-BD3E-92FD6B14F6EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000584", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000584
	///</summary>
	public class Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow1);

		}
	}


	[NVP_Manifest(
		Id = "46B688BE-A6D3-43E7-A27F-9726894DF71B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000584", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000584
	///</summary>
	public class Set_Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow1 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F33697B3-D114-4305-9D37-9390C4E7D321", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000585", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000585
	///</summary>
	public class Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow2);

		}
	}


	[NVP_Manifest(
		Id = "5C8A6C12-8998-4085-86A4-B2FDDB5BAA0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000585", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000585
	///</summary>
	public class Set_Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow2 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00240A98-EAFA-4788-999B-182E84DFA027", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000586", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000586
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "4F0C92BB-A72D-42F0-A19C-65BF33A1A248", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000586", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000586
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A2A951CD-52A6-4176-ACA5-90E836870D5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000587", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000587
	///</summary>
	public class LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinePosition);

		}
	}


	[NVP_Manifest(
		Id = "E03DE207-DA8E-40DD-A5F9-26AF035B02AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimAngle.Set_LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimAngle", 
		NodeName = "Set_LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000587", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000587
	///</summary>
	public class Set_LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinePosition = inputs[1].Value;
			return null;
		}
	}
}
