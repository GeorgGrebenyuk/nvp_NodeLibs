using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing dimension
///</summary>
namespace McCOM2.SymDimension 
{

	[NVP_Manifest(
		Id = "F27515AA-E048-4C5C-A741-383FE1ED1B78", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.SymDimension_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "_SymDimension_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimension_Constructor : INode 
	{
		public McCOM2.ISymDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6EBA0CE6-0FA9-408F-92D3-AEC280C40E9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.SymDimension_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "_SymDimension_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimension_ConstructorCast : INode 
	{
		public McCOM2.ISymDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AA6CD684-7E3D-4EE2-9088-7CEACABCFC70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000161", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000161
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
		Id = "CA640D19-E2FE-429C-BE05-5567C1CDCC1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000161", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000161
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
		Id = "EA0CE3C6-7A37-472C-953C-AC4A15FAAB18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000165", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000165
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
		Id = "E12AE1D8-75B6-4617-B2DC-F3F9B71DB60A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Upper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Upper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000164", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000164
	///</summary>
	public class Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Upper);

		}
	}


	[NVP_Manifest(
		Id = "5A8E162B-4C05-426A-AAB5-9EBA87441461", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Upper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Upper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000164", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000164
	///</summary>
	public class Set_Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Upper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "54B3E1B2-83D9-45EF-8928-8DD741125DAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Lower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Lower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000156", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000156
	///</summary>
	public class Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lower);

		}
	}


	[NVP_Manifest(
		Id = "A9D069EA-3924-4F7F-8AB7-E912E0A8953D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Lower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Lower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000156", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000156
	///</summary>
	public class Set_Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lower = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "52F2FA2D-8D20-4DBD-88B5-C31D3CFD3DAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Quality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Quality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015c", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015c
	///</summary>
	public class Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Quality);

		}
	}


	[NVP_Manifest(
		Id = "4197BB09-26B8-4B16-BEBA-82F5287F4E80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Quality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Quality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015c", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000015c
	///</summary>
	public class Set_Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B32576E-1909-412E-8C1B-426C3ED65A64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Field", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Field", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014e", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014e
	///</summary>
	public class Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Field);

		}
	}


	[NVP_Manifest(
		Id = "DF5C1366-5F35-49B3-934B-798AC775F5F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Field", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Field", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000014e
	///</summary>
	public class Set_Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Field = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3040E788-9910-4B7C-831B-D0D36B5A4360", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.TolView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "TolView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000162", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000162
	///</summary>
	public class TolView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TolView);

		}
	}


	[NVP_Manifest(
		Id = "69EE5112-3935-4FA9-9EB7-411F5C84FD6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_TolView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_TolView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000162", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionTolView", typeof(System.Object))]

	///<summary>
	///0x00000162
	///</summary>
	public class Set_TolView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TolView = ((McCOM2.SymDimensionTolView)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "635A7C9E-58BB-43ED-AAF5-17E2BD40D74F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Brackets", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Brackets", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014a", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014a
	///</summary>
	public class Brackets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Brackets);

		}
	}


	[NVP_Manifest(
		Id = "8B808F31-0CCE-4FD3-86F9-B71399E60864", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Brackets", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Brackets", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionBracket", typeof(System.Object))]

	///<summary>
	///0x0000014a
	///</summary>
	public class Set_Brackets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Brackets = ((McCOM2.SymDimensionBracket)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8C4BF4EE-A274-482B-B282-A67602E6D2BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Rect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Rect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015e", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015e
	///</summary>
	public class Rect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rect);

		}
	}


	[NVP_Manifest(
		Id = "0AF70F00-A818-42EC-9DF3-03AED1B936EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Rect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Rect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000015e
	///</summary>
	public class Set_Rect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rect = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F2903268-E0D2-49E7-8E3A-968A31A7C015", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Leader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Leader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000152", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000152
	///</summary>
	public class Leader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leader);

		}
	}


	[NVP_Manifest(
		Id = "CEA73C21-B957-4A65-B411-1FC62949A1B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Leader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Leader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000152", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000152
	///</summary>
	public class Set_Leader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Leader = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "51C2E71F-6C99-4FC1-B722-4221E632FDF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Real", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Real", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015d", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015d
	///</summary>
	public class Real : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Real);

		}
	}


	[NVP_Manifest(
		Id = "0E41F940-DFFE-4E75-BEE2-5679BCCC0DDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Real", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Real", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015d", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000015d
	///</summary>
	public class Set_Real : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Real = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C15111F-615D-4CCC-9060-532A2FC0C1CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000160", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000160
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
		Id = "35140C62-F0CE-42FB-A3CA-8AC8C8EE6203", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000160", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000160
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
		Id = "FF2E8D36-3986-4F80-B8C0-4CFFD45CA90A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015a", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015a
	///</summary>
	public class Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prefix);

		}
	}


	[NVP_Manifest(
		Id = "4882994C-FEFA-4E16-BFD1-CAE8717EFEBC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000015a
	///</summary>
	public class Set_Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1ED3379A-9B0E-47D6-98F6-755C046F7156", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Suffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Suffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015f", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015f
	///</summary>
	public class Suffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Suffix);

		}
	}


	[NVP_Manifest(
		Id = "3229C659-7958-43F4-B31B-9180D80A9638", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Suffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Suffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000015f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000015f
	///</summary>
	public class Set_Suffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Suffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "17B4BC38-CEF2-4F91-8F1F-7A09A9D39EC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Postfix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Postfix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000159", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000159
	///</summary>
	public class Postfix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Postfix);

		}
	}


	[NVP_Manifest(
		Id = "AEB3845C-8AD2-495C-AF8F-D5ED2627DF0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Postfix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Postfix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000159", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000159
	///</summary>
	public class Set_Postfix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Postfix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "006AA0BD-A50A-4787-AEB3-6839D6E3E2FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014f", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014f
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
		Id = "680F23A8-09AC-4C79-9126-44AC3357A5BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000014f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000014f
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
		Id = "28FDEEED-A41A-4C5C-B9F5-5405DF6CC5BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Symbol", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Symbol", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000588", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000588
	///</summary>
	public class Symbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Symbol);

		}
	}


	[NVP_Manifest(
		Id = "FB2A26BA-C2E5-413C-9E8D-6CD19459E73F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimension.Set_Symbol", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimension", 
		NodeName = "Set_Symbol", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000588", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionSymbol", typeof(System.Object))]

	///<summary>
	///0x00000588
	///</summary>
	public class Set_Symbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Symbol = ((McCOM2.SymDimensionSymbol)inputs[1].Value);
			return null;
		}
	}
}
