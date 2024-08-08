using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Gradient or taper designation
///</summary>
namespace McCOM2.SymGradient 
{

	[NVP_Manifest(
		Id = "EF58F62F-7A75-40F6-8218-DA82CCCFD41D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.SymGradient_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "_SymGradient_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymGradient_Constructor : INode 
	{
		public McCOM2.ISymGradient _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymGradient;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "865AD52A-7DC8-4081-A396-B19EEE578996", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.SymGradient_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "_SymGradient_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymGradient_ConstructorCast : INode 
	{
		public McCOM2.ISymGradient _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymGradient;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "00E7AF70-1EB6-4A80-A890-BD8A2D6CC2A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Taper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Taper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025e", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025e
	///</summary>
	public class Taper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Taper);

		}
	}


	[NVP_Manifest(
		Id = "B33B15DD-044A-4B74-8194-30BBCB98A8B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Taper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Taper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025e", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbType", typeof(System.Object))]

	///<summary>
	///0x0000025e
	///</summary>
	public class Set_Taper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Taper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2A448FF1-B50D-4E32-AD58-C0E4443A58F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.RightToLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "RightToLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025d", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025d
	///</summary>
	public class RightToLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RightToLeft);

		}
	}


	[NVP_Manifest(
		Id = "1B17E879-04A3-4F6B-92D5-EAF3B55BA875", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_RightToLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_RightToLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025d", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbType", typeof(System.Object))]

	///<summary>
	///0x0000025d
	///</summary>
	public class Set_RightToLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RightToLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ECBAA5E0-36B6-402E-8E6A-C483C0A85AC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Units", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Units", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000261", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000261
	///</summary>
	public class Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Units);

		}
	}


	[NVP_Manifest(
		Id = "1AEEF459-ECCB-4EE0-85EB-5E033B270BA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Units", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Units", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000261", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("McCOM2.GradientUnitType", typeof(System.Object))]

	///<summary>
	///0x00000261
	///</summary>
	public class Set_Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Units = ((McCOM2.GradientUnitType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46030462-4B17-4351-A3AD-CDB8CC890D7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Associative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Associative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000024a", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000024a
	///</summary>
	public class Associative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Associative);

		}
	}


	[NVP_Manifest(
		Id = "654604B4-A7DD-4C31-B4CE-884001DF4A07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Associative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Associative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000024a", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000024a
	///</summary>
	public class Set_Associative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Associative = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "348224F6-1306-4E73-ADA0-863369170E9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.OnPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "OnPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000259", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000259
	///</summary>
	public class OnPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OnPlane);

		}
	}


	[NVP_Manifest(
		Id = "5735C83E-0F24-42C6-8210-3B23F67275F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_OnPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_OnPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000259", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000259
	///</summary>
	public class Set_OnPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E5B55640-B070-452E-A46E-DDA66B04C3F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.DisplayText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "DisplayText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000250", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000250
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Id = "81F93D45-D581-42F7-A651-83830BCCFDA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025f", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025f
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
		Id = "86EB16FC-38C0-40F4-B409-C48CFE456B30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025f", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x0000025f
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
		Id = "2F1C2E97-46D2-4F3D-8EC9-913DC95888F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025a", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025a
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
		Id = "07273A93-C4C8-4467-86AB-A4FE96D02465", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025a", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000025a
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
		Id = "02BB2369-0FC2-4DEA-B7C6-6F0E4ABE81F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000260", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000260
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
		Id = "1002A917-FC30-4C47-A484-4E6E23A687A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000260", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000260
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
		Id = "2B59B31F-3641-410E-8D3A-19028D973663", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.ReferenceDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "ReferenceDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025c", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025c
	///</summary>
	public class ReferenceDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReferenceDir);

		}
	}


	[NVP_Manifest(
		Id = "8BF2DDA2-172F-4A79-B584-8135397F78FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_ReferenceDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_ReferenceDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000025c", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x0000025c
	///</summary>
	public class Set_ReferenceDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ReferenceDir = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B9B558B-DF41-4D65-AC93-423EE4EF9013", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000024f", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000024f
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
		Id = "A184C28D-B5D0-4561-8A3B-FF567D290777", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000024f", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x0000024f
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
		Id = "6A519588-3131-4A01-A176-D32E7254D7E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymGradient.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymGradient", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000258", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000258
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
