using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to provide an access to drawing properties such as the Title, Subject, Author, and Keywords properties
///</summary>
namespace OdaX.AcadSummaryInfo 
{

	[NVP_Manifest(
		Id = "2D2451B4-1337-4F05-9A8D-B7CC5CAB5B9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.AcadSummaryInfo_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "_AcadSummaryInfo_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSummaryInfo_Constructor : INode 
	{
		public OdaX.IAcadSummaryInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSummaryInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C374BDE3-9E88-471B-AFE0-9531A30264FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.AcadSummaryInfo_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "_AcadSummaryInfo_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSummaryInfo_ConstructorCast : INode 
	{
		public OdaX.IAcadSummaryInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSummaryInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BBE66F34-E8BA-46CE-A93E-22DD7D5B082A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Author", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Author", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the author value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the author value of the summary information.
	///</summary>
	public class Author : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Author);

		}
	}


	[NVP_Manifest(
		Id = "D4F89ABA-D620-4D9D-B633-CE8649E35920", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_Author", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_Author", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the author value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pAuthor", typeof(System.String))]

	///<summary>
	///Specifies or returns the author value of the summary information.
	///</summary>
	public class Set_Author : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Author = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B6814FF2-A9F9-44D2-A394-62A7E3E6802F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Comments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Comments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the comments value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the comments value of the summary information.
	///</summary>
	public class Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comments);

		}
	}


	[NVP_Manifest(
		Id = "BB3A3959-5DBB-4E74-95F0-1AE661DFF558", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_Comments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_Comments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the comments value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pComments", typeof(System.String))]

	///<summary>
	///Specifies or returns the comments value of the summary information.
	///</summary>
	public class Set_Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F97C940D-4B23-4FAC-9DA0-2C36687861D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.HyperlinkBase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "HyperlinkBase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hyperlink base value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the hyperlink base value of the summary information.
	///</summary>
	public class HyperlinkBase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkBase);

		}
	}


	[NVP_Manifest(
		Id = "91FFF3D9-4531-4553-91A6-69F08AD7086E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_HyperlinkBase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_HyperlinkBase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hyperlink base value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pHyperlinkBase", typeof(System.String))]

	///<summary>
	///Specifies or returns the hyperlink base value of the summary information.
	///</summary>
	public class Set_HyperlinkBase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkBase = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "079DA3AE-16DD-495A-854C-88FCB471BA21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Keywords", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Keywords", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the keywords value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the keywords value of the summary information.
	///</summary>
	public class Keywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Keywords);

		}
	}


	[NVP_Manifest(
		Id = "02591178-318B-4FA3-B332-773F1AB6D5C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_Keywords", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_Keywords", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the keywords value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pKeywords", typeof(System.String))]

	///<summary>
	///Specifies or returns the keywords value of the summary information.
	///</summary>
	public class Set_Keywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Keywords = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "263FD1CB-C6DD-44F9-A646-87B43148EDCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.LastSavedBy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "LastSavedBy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the login name of the user who last saved the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the login name of the user who last saved the drawing.
	///</summary>
	public class LastSavedBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LastSavedBy);

		}
	}


	[NVP_Manifest(
		Id = "E3A0A29E-FF08-4070-9941-BD3BC31E2F39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_LastSavedBy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_LastSavedBy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the login name of the user who last saved the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pLastSavedBy", typeof(System.String))]

	///<summary>
	///Specifies or returns the login name of the user who last saved the drawing.
	///</summary>
	public class Set_LastSavedBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LastSavedBy = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B250AE0F-CD11-4A1D-924F-2EDF1153C364", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.RevisionNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "RevisionNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the revision number value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the revision number value of the summary information.
	///</summary>
	public class RevisionNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RevisionNumber);

		}
	}


	[NVP_Manifest(
		Id = "563DE996-5C0B-4C98-A815-CB11E8F0DB1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_RevisionNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_RevisionNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the revision number value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pRevisionNumber", typeof(System.String))]

	///<summary>
	///Specifies or returns the revision number value of the summary information.
	///</summary>
	public class Set_RevisionNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RevisionNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BB04B50E-E3B0-4C86-84A4-27140299B2DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Subject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Subject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the subject value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the subject value of the summary information.
	///</summary>
	public class Subject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Subject);

		}
	}


	[NVP_Manifest(
		Id = "FC035628-1F29-476E-AFC2-82BA6A8574E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_Subject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_Subject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the subject value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pSubject", typeof(System.String))]

	///<summary>
	///Specifies or returns the subject value of the summary information.
	///</summary>
	public class Set_Subject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Subject = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A25BCA72-0BAE-48F3-930B-736BC3E35BDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Title", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Title", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the title value of the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Specifies or returns the title value of the summary information.
	///</summary>
	public class Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Title);

		}
	}


	[NVP_Manifest(
		Id = "FF179504-5D47-4F7F-B535-745042B39260", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.Set_Title", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "Set_Title", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the title value of the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("pTitle", typeof(System.String))]

	///<summary>
	///Specifies or returns the title value of the summary information.
	///</summary>
	public class Set_Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Title = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9061A745-2F38-426F-9A97-B13A4B22373F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.NumCustomInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "NumCustomInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of custom information items that have been defined for the summary information.", 
		ViewType = "Data")]
	[NodeInput("AcadSummaryInfo", typeof(object))]

	///<summary>
	///Returns the number of custom information items that have been defined for the summary information.
	///</summary>
	public class NumCustomInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCustomInfo);

		}
	}


	[NVP_Manifest(
		Id = "2F9D171E-63BF-4E45-88FA-A25925421532", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.GetCustomByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "GetCustomByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Using an index, returns the key and value of custom information that is defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pKey", typeof(System.String))]
	[NodeInput("pValue", typeof(System.String))]

	///<summary>
	///Using an index, returns the key and value of custom information that is defined for the summary information.
	///</summary>
	public class GetCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomByIndex(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10FBAAD8-2B27-40DF-8A99-47E6EFDD1132", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.GetCustomByKey", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "GetCustomByKey", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Using a key, returns the key and value of custom information that is defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("pValue", typeof(System.String))]

	///<summary>
	///Using a key, returns the key and value of custom information that is defined for the summary information.
	///</summary>
	public class GetCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomByKey(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "69687DDA-1774-427C-863B-5BC35A75498D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.SetCustomByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "SetCustomByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Using an index, specifies the key and value of custom information defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Using an index, specifies the key and value of custom information defined for the summary information.
	///</summary>
	public class SetCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomByIndex(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16EC5C5C-3627-48B9-B572-2D57191BCC46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.SetCustomByKey", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "SetCustomByKey", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Using a key, specifies the key and value of custom information defined for the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Using a key, specifies the key and value of custom information defined for the summary information.
	///</summary>
	public class SetCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomByKey(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE87A808-EEC3-4A29-AC37-48CAC938A996", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.AddCustomInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "AddCustomInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "name) and value to the summary information.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///name) and value to the summary information.
	///</summary>
	public class AddCustomInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddCustomInfo(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF554802-B3D7-4459-A778-AAD7D7EE3E24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.RemoveCustomByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "RemoveCustomByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes custom information using its index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Removes custom information using its index.
	///</summary>
	public class RemoveCustomByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveCustomByIndex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1F4B568F-BF64-4882-870D-FAA1680748AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSummaryInfo.RemoveCustomByKey", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSummaryInfo", 
		NodeName = "RemoveCustomByKey", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes custom information using its key.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSummaryInfo", typeof(object))]
	[NodeInput("key", typeof(System.String))]

	///<summary>
	///Removes custom information using its key.
	///</summary>
	public class RemoveCustomByKey : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveCustomByKey(inputs[1].Value);
			return null;
		}
	}
}
