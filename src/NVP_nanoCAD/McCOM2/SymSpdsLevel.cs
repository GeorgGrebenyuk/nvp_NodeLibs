using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Level mark
///</summary>
namespace McCOM2.SymSpdsLevel 
{

	[NVP_Manifest(
		Id = "C7CB0EDE-51B3-4A12-99A6-C66E1647D8CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.SymSpdsLevel_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "_SymSpdsLevel_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsLevel_Constructor : INode 
	{
		public McCOM2.ISymSpdsLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "350E6B63-FA48-4755-8759-C15E7F63FB19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.SymSpdsLevel_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "_SymSpdsLevel_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsLevel_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CEC411DE-0037-451C-BE84-006FB91B6E4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000396", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000396
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
		Id = "49F96936-6D6D-47C6-9CDC-97E52CBB2678", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000396", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000396
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
		Id = "61D1715B-6423-4B0A-A3C3-1F9EB08E3AF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.DisplayText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "DisplayText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000388", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000388
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
		Id = "2BD7CBA0-EDB4-4360-A8B4-878EBE5DD17E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000389", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000389
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
		Id = "F7D1EB05-7C5D-4CD8-9DDD-46B969E05FFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000389", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000389
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
		Id = "716528C2-3BF1-4F3E-8081-D816400558F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000383", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000383
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Id = "1E115AC2-528F-47B0-BA24-BE057CD7866E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000383", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("ppBase", typeof(System.Object))]

	///<summary>
	///0x00000383
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "979328FC-3F6C-41B9-B418-92F83311FC4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000392", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000392
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "EB6E905B-21CC-419F-AEAF-80F011F05CC7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000392", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000392
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6F5CA7D-3A0D-43C2-AFE7-8E857D8DC971", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000393", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000393
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
		Id = "8F6F6A41-C91C-45E9-BA49-C1EC962C0FDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000393", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000393
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
		Id = "7A19CA1A-4840-4376-A8A9-1ED3BFACC1C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000395", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000395
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
		Id = "01C842C4-48C6-48CC-B67D-4DA2D051550D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000395", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000395
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
		Id = "71B07A6F-AFCD-4350-8DA4-7013854FE334", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Associative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Associative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000382", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000382
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
		Id = "6EAD7E6E-9700-47D5-8B22-5FD1EDF5BAEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Associative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Associative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000382", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000382
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
		Id = "6C07CD99-94CE-4162-97BA-3CFDC6F84B51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Mirrored", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Mirrored", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000038f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x0000038f
	///</summary>
	public class Mirrored : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirrored);

		}
	}


	[NVP_Manifest(
		Id = "6A1E9433-C5C8-45D3-BDBC-872C2D491545", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.Set_Mirrored", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "Set_Mirrored", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000038f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000038f
	///</summary>
	public class Set_Mirrored : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mirrored = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9FF23409-82AC-4F68-95EE-7DA9D728C1F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsLevel.AffectsTo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsLevel", 
		NodeName = "AffectsTo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000037a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x0000037a
	///</summary>
	public class AffectsTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsTo);

		}
	}
}
