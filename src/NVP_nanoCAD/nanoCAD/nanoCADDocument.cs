using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///A drawing
///</summary>
namespace nanoCAD.nanoCADDocument 
{

	[NVP_Manifest(
		Id = "7F3C610C-A6B9-4EFF-80EB-1CA7620A9B4A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.nanoCADDocument_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "_nanoCADDocument_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocument_Constructor : INode 
	{
		public nanoCAD.InanoCADDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "078D62D5-0ECE-4A89-A97E-87C63006DEA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.nanoCADDocument_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "_nanoCADDocument_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocument_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7148D9F3-A07B-421E-8BD2-D9446AD58AB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Plot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Plot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Plot object for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the Plot object for the document
	///</summary>
	public class Plot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Plot);

		}
	}


	[NVP_Manifest(
		Id = "3F9034DB-EC71-4940-81A9-AEFDD85EE2A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layer", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayer);

		}
	}


	[NVP_Manifest(
		Id = "43F2C139-52DE-444D-81DA-0B21A7EDD592", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layer", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class Set_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "39087698-D7D7-4500-8CE5-C350C3F46F82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLinetype);

		}
	}


	[NVP_Manifest(
		Id = "A3DC6B38-1AD2-4328-904C-C5FB0A855872", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class Set_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A51CB2A8-0619-4E06-946F-F0DEEC0F6542", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveDimStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveDimStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active dimension style", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDimStyle);

		}
	}


	[NVP_Manifest(
		Id = "FE8B040F-8BB4-4AB7-BA22-718BB822E926", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveDimStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveDimStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active dimension style", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class Set_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8909BC31-8F46-4BEA-A9BC-6535E37279C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "9E925770-66FE-4A19-B4F5-C19ACCD759BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class Set_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6296356-0048-4483-8347-3F8D41A8CEFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveUCS);

		}
	}


	[NVP_Manifest(
		Id = "D04FE551-FAB9-47BC-9D57-87704F31199A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class Set_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10032D37-4054-4600-BA61-D3F2207ACF5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveViewport);

		}
	}


	[NVP_Manifest(
		Id = "61D50392-0D08-4E26-BEF5-A1489F6CB336", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class Set_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "98C40239-A5B1-4452-9FB8-33089D07A997", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActivePViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActivePViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActivePViewport);

		}
	}


	[NVP_Manifest(
		Id = "83364EF4-B80B-424C-B1B7-3733FA406FDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActivePViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActivePViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class Set_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "280D204E-8023-4302-A7B9-470400095A9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Toggles the active space between paper space and model space", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	public class ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSpace);

		}
	}


	[NVP_Manifest(
		Id = "C7B0E3FE-4B59-4629-83D0-A0963EEAAC07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Toggles the active space between paper space and model space", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("nanoCAD.AcActiveSpace", typeof(System.Object))]

	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	public class Set_ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveSpace = ((nanoCAD.AcActiveSpace)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6306A908-5743-4A71-AC2E-388FD5030F58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.SelectionSets", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "SelectionSets", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the SelectionSets collection for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the SelectionSets collection for the document
	///</summary>
	public class SelectionSets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectionSets);

		}
	}


	[NVP_Manifest(
		Id = "2F77349E-8819-4BAA-ADEC-8E1E9D0C0689", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveSelectionSet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveSelectionSet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the active selection set for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the active selection set for the drawing
	///</summary>
	public class ActiveSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSelectionSet);

		}
	}


	[NVP_Manifest(
		Id = "14B4EEF1-3818-4630-A905-BC496185C190", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.FullName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "FullName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the name of the application or document, including the path", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the name of the application or document, including the path
	///</summary>
	public class FullName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullName);

		}
	}


	[NVP_Manifest(
		Id = "6D1518F4-3087-4037-9EBA-1E3DA4C55DB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Id = "9109699F-F3B8-419B-933D-483B287BDB28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the path of the document, application, or external reference", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the path of the document, application, or external reference
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Id = "E065782C-6A36-452F-82B1-4E8D5ACDB54F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ObjectSnapMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ObjectSnapMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the setting of the object snap mode", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	public class ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSnapMode);

		}
	}


	[NVP_Manifest(
		Id = "1EF073E2-2104-4A7A-8078-1E2A88DA39FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ObjectSnapMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ObjectSnapMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the setting of the object snap mode", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("fSnapMode", typeof(System.Object))]

	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	public class Set_ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSnapMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7CC8BA23-7DF9-4DF1-9D12-CA7BF825BE73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ReadOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ReadOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the document is read-only or read-write", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies if the document is read-only or read-write
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}


	[NVP_Manifest(
		Id = "CAA620EB-60B8-419A-99E8-06E6BF87309A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Saved", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Saved", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the document has any unsaved changes", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies if the document has any unsaved changes
	///</summary>
	public class Saved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Saved);

		}
	}


	[NVP_Manifest(
		Id = "DA73AFF9-3BD9-40E8-AC1A-AA681E628BEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.MSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "MSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Allows editing of the model from floating paper space viewports", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	public class MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MSpace);

		}
	}


	[NVP_Manifest(
		Id = "38738A04-2583-42C3-B17E-1CF6C96B4225", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_MSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_MSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Allows editing of the model from floating paper space viewports", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]

	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	public class Set_MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8757D655-E3E6-4B5C-B106-FE72AF5A5F66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Utility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Utility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Utility object for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the Utility object for the document
	///</summary>
	public class Utility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Utility);

		}
	}


	[NVP_Manifest(
		Id = "18616CF1-9A18-4814-9B73-A5F18808926A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Open", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Open", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DWG) and makes it the active document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullName", typeof(System.String))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///DWG) and makes it the active document
	///</summary>
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Open(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "518E42D5-EFB2-4AA9-913D-969A9751DF1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.AuditInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "AuditInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Evaluates the integrity of the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FixErr", typeof(System.Object))]

	///<summary>
	///Evaluates the integrity of the drawing
	///</summary>
	public class AuditInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AuditInfo(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "29BB901F-19AF-42C1-B6F0-EE6C8D60DE0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Import", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Import", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Imports a drawing file in SAT, EPS, DXF, or WMF format", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Imports a drawing file in SAT, EPS, DXF, or WMF format
	///</summary>
	public class Import : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Import(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "73402557-DB59-48CF-B6DF-872DE2710DA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Export", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Export", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Exports the drawing to a WMF, SAT, EPS, DXF, or BMP format", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("Extension", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]

	///<summary>
	///Exports the drawing to a WMF, SAT, EPS, DXF, or BMP format
	///</summary>
	public class Export : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Export(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4362B7AF-3101-47C3-9E2D-90B5B9BC5607", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.New", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "New", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a new document in SDI mode", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("TemplateFileName", typeof(System.String))]

	///<summary>
	///Creates a new document in SDI mode
	///</summary>
	public class New : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.New(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "3C132682-EB3B-4601-9FE7-210C42D97988", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Save", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Save", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves the document or menu group", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Saves the document or menu group
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DACAD29B-77BF-4F93-BD91-85907F5E1586", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.SaveAs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "SaveAs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves the document or menu group to a specified file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8FE13A43-3F92-4307-A6CF-D4B83B99340B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Wblock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Wblock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Writes out the given selection set as a new drawing file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]

	///<summary>
	///Writes out the given selection set as a new drawing file
	///</summary>
	public class Wblock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Wblock(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5C548A61-A5BD-4851-A49A-B20B8CD4D3ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.PurgeAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "PurgeAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes unused named references such as unused blocks or layers from the document", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Removes unused named references such as unused blocks or layers from the document
	///</summary>
	public class PurgeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PurgeAll();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A265FF88-D342-4F2D-A949-F60D015AA7D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.GetVariable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "GetVariable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the current setting of a system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Gets the current setting of a system variable
	///</summary>
	public class GetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVariable(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "50D901B0-2A17-456E-B788-738FC34BBD87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.SetVariable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "SetVariable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the value of a system variable", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Sets the value of a system variable
	///</summary>
	public class SetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetVariable(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31571D31-9400-4615-8056-9D90DAFC9FDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Regen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Regen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("nanoCAD.AcRegenType", typeof(System.Object))]

	///<summary>
	///Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects
	///</summary>
	public class Regen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Regen(((nanoCAD.AcRegenType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E512D3FA-C487-46ED-8003-D18468DDB1AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.PickfirstSelectionSet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "PickfirstSelectionSet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the pickfirst selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the pickfirst selection set
	///</summary>
	public class PickfirstSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickfirstSelectionSet);

		}
	}


	[NVP_Manifest(
		Id = "1D85DA4E-6942-45EB-97EC-FA7DD39D8981", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Active", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Active", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if the document is the active document for the session", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Determines if the document is the active document for the session
	///</summary>
	public class Active : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Active);

		}
	}


	[NVP_Manifest(
		Id = "12FF5A16-E55A-4453-8256-B5486B3640DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Activate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Activate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Makes the specified drawing active", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Makes the specified drawing active
	///</summary>
	public class Activate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Activate();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8542514B-2E69-4F97-8252-E73DF568C0D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Close", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Close", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Closes the specified drawing, or all open drawings", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("SaveChanges", typeof(System.Object))]
	[NodeInput("FileName", typeof(System.Object))]

	///<summary>
	///Closes the specified drawing, or all open drawings
	///</summary>
	public class Close : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Close(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "62C39A59-22E7-4DA8-87B8-DCABF2DCDDB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_WindowState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_WindowState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the state of the application or document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("nanoCAD.AcWindowState", typeof(System.Object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class Set_WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowState = ((nanoCAD.AcWindowState)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6F5E5CF2-F75D-4D62-A76E-569A6F5ACCB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.WindowState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "WindowState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the state of the application or document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowState);

		}
	}


	[NVP_Manifest(
		Id = "56177B23-97D7-42A3-A9E0-17CA6C5F84D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pWidth", typeof(System.Int32))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
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
		Id = "29B90303-65BD-45C3-AB30-6C1DA9CF7DA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
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
		Id = "0AD154EE-14BC-4284-B6AA-10BA7B54E4F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pHeight", typeof(System.Int32))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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


	[NVP_Manifest(
		Id = "87EF4528-C110-4BED-B8B9-BCA595EF1301", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Id = "75278A10-8A3B-45EE-968B-0A6EBA6D027E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_ActiveLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_ActiveLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class Set_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B7B6C218-223D-4906-8066-A61EB93770F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.ActiveLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "ActiveLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layout", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayout);

		}
	}


	[NVP_Manifest(
		Id = "66C0DC55-AE10-4BD6-9B50-E1E143EE660C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.SendCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "SendCommand", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sends a command string from a VB or VBA application to the document for processing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Command", typeof(System.String))]

	///<summary>
	///Sends a command string from a VB or VBA application to the document for processing
	///</summary>
	public class SendCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SendCommand(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3CF6363D-75A7-4FB5-AFC0-233BCF489EED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.HWND", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "HWND", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the window handle of the document window frame", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the window handle of the document window frame
	///</summary>
	public class HWND : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HWND);

		}
	}


	[NVP_Manifest(
		Id = "18D715DF-71A3-42D6-97A1-AFFCB53CBC7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.WindowTitle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "WindowTitle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the title of the document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the title of the document window
	///</summary>
	public class WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTitle);

		}
	}


	[NVP_Manifest(
		Id = "95FB899E-DA3B-490F-BEE3-0B9A50390A18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Set_WindowTitle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Set_WindowTitle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the title of the document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the title of the document window
	///</summary>
	public class Set_WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTitle[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "26A2A505-F70C-47CE-8766-77E97962EADE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the Application object
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
		Id = "144332B5-0295-4D93-B3C8-5BD51AD8420A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Database", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Database", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the database in which the object belongs", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the database in which the object belongs
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}


	[NVP_Manifest(
		Id = "88B5DE28-5C44-4F85-8064-A67A77C6FC5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.StartUndoMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "StartUndoMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Marks the beginning of a block of operations", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Marks the beginning of a block of operations
	///</summary>
	public class StartUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartUndoMark();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C271C67B-1626-4795-B1E2-923CB6BF4377", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.EndUndoMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "EndUndoMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Marks the end of a block of operations", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Marks the end of a block of operations
	///</summary>
	public class EndUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndUndoMark();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6A57B68-A638-4080-AC1E-40382F42E541", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.AddCustomObjectToBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "AddCustomObjectToBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "add custom object to block", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("rxClass", typeof(System.String))]
	[NodeInput("blk", typeof(System.Object))]

	///<summary>
	///add custom object to block
	///</summary>
	public class AddCustomObjectToBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCustomObjectToBlock(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "E768E0D9-94A2-41C1-BEFF-344E76530CC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class Put_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1D2010CF-CDEC-418B-9BE8-300541AA0830", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layer", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class Put_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B1CE3BB-38CF-4351-8C0D-DD3B57D37765", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class Put_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4C7C383-C19B-4949-BF6B-E5887ECBC0A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveDimStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveDimStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active dimension style", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class Put_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC9A4ADD-B499-4147-83B3-E534F24053D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class Put_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2E5FD378-D343-463D-8D32-58BD1EE1114F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class Put_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC78823C-606C-44FB-9DA8-458031626E4A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActivePViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActivePViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class Put_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ABB92DEF-E2E9-4FC3-8106-9CDBE3387303", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocument.Put_ActiveLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocument", 
		NodeName = "Put_ActiveLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the active layout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class Put_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1].Value;
			return null;
		}
	}
}
