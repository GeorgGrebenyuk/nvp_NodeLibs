using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Permanent connection mark
///</summary>
namespace McCOM2.SymFix 
{

	[NVP_Manifest(
		Id = "80D27611-9AAA-42B7-ADF3-BBEE1B712487", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.SymFix_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "_SymFix_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFix_Constructor : INode 
	{
		public McCOM2.ISymFix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymFix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7272AA5E-088D-4203-B93A-9E1263BFA8BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.SymFix_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "_SymFix_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFix_ConstructorCast : INode 
	{
		public McCOM2.ISymFix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymFix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "577E90D3-7DFC-44C9-8E48-A510C45FC15F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000021e", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000021e
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
		Id = "C9523608-19BC-4FEB-A020-F4DBE0C462DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000021e", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000021e
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
		Id = "04AAB2C2-B96D-4F1A-A9A5-FF39E5CD984B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000224", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000224
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
		Id = "EE55EB7B-6F9E-4CF1-AE8B-B947DB0A04A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000224", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000224
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
		Id = "B605801F-82E6-4A20-BAAA-FD056D39FBB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000223", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000223
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
		Id = "51B11F20-6627-468D-9D14-3812968050B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000223", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000223
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
		Id = "230E130E-ED01-4B77-B067-2B78D626E158", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000214", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000214
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
		Id = "2638FE07-829F-49C6-9497-4720B0A1DF6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000214", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000214
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
		Id = "ABE99038-6DC5-4707-B051-F184FA8DF8D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Documentation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Documentation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000212", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000212
	///</summary>
	public class Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documentation);

		}
	}


	[NVP_Manifest(
		Id = "77605265-F0DC-4737-961F-12417BEFEA39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Documentation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Documentation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000212", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000212
	///</summary>
	public class Set_Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Documentation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "68E636DE-85AB-4E62-ABE7-1DB142A3E751", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.LeaderText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "LeaderText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000218", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000218
	///</summary>
	public class LeaderText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderText);

		}
	}


	[NVP_Manifest(
		Id = "6DEB8867-C91F-413E-BE8B-F26C9A5859CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_LeaderText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_LeaderText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000218", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000218
	///</summary>
	public class Set_LeaderText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderText = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "502CB519-1E3B-4BE7-BBBC-B25C1D792D7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.LeaderFooter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "LeaderFooter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000217", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000217
	///</summary>
	public class LeaderFooter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderFooter);

		}
	}


	[NVP_Manifest(
		Id = "0421B27B-97AC-4FFA-B7E6-1660198112B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_LeaderFooter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_LeaderFooter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000217", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000217
	///</summary>
	public class Set_LeaderFooter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderFooter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F7259666-D7E6-476C-A68D-BA6A0E2EFC1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000225", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000225
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "D4EA2DD6-41F6-437E-B250-82CCF73026EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000225", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("McCOM2.SymFixType", typeof(System.Object))]

	///<summary>
	///0x00000225
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymFixType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B2F4E179-FC36-4AA6-ADE8-6D5AA66C81E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Technology", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Technology", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000222", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000222
	///</summary>
	public class Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Technology);

		}
	}


	[NVP_Manifest(
		Id = "C5C77511-A595-4368-89CD-1B8724A1E62C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Technology", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Technology", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000222", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("McCOM2.SymFixTechnology", typeof(System.Object))]

	///<summary>
	///0x00000222
	///</summary>
	public class Set_Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Technology = ((McCOM2.SymFixTechnology)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24CA824F-D1A6-434D-899A-4259016FA9FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Face", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Face", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000213", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000213
	///</summary>
	public class Face : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Face);

		}
	}


	[NVP_Manifest(
		Id = "B07241C2-755E-4884-89AC-9ACEF3D865AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Face", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Face", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000213", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000213
	///</summary>
	public class Set_Face : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Face = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3ED4D4D2-08D0-4593-9917-92D8942AB4B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000020f", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000020f
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Id = "13AF719E-7BD5-4FBC-8E71-6DFF0B47666E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000020f", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000020f
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58487FBF-E6E0-4F83-963C-3EA7B2F0F1BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Assembly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Assembly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000020c", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000020c
	///</summary>
	public class Assembly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Assembly);

		}
	}


	[NVP_Manifest(
		Id = "F3815AEC-1500-4FF8-A002-9B54FCB2D0A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_Assembly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_Assembly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000020c", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbAssembly", typeof(System.Object))]

	///<summary>
	///0x0000020c
	///</summary>
	public class Set_Assembly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Assembly = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E99E9471-7D55-4F30-AFF6-9CEC2FB4455E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.SeamCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "SeamCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000220", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000220
	///</summary>
	public class SeamCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SeamCount);

		}
	}


	[NVP_Manifest(
		Id = "5F367567-58DB-4113-A19B-292ECB3E9952", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_SeamCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_SeamCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000220", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x00000220
	///</summary>
	public class Set_SeamCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SeamCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4DB4F743-E5E5-4023-B592-F5774F44FC2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.SeamDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "SeamDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000221", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000221
	///</summary>
	public class SeamDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SeamDistance);

		}
	}


	[NVP_Manifest(
		Id = "3A27ACCB-7B82-4DF3-AFCC-AB19950EA2AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFix.Set_SeamDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFix", 
		NodeName = "Set_SeamDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000221", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000221
	///</summary>
	public class Set_SeamDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SeamDistance = inputs[1].Value;
			return null;
		}
	}
}
