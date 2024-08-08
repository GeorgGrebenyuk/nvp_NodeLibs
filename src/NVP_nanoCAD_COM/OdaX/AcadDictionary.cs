using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a container object for storing and retrieving objects
///</summary>
namespace OdaX.AcadDictionary 
{

	[NVP_Manifest(
		Id = "DEA0B26D-2E31-45AD-BC54-4FC103733246", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.AcadDictionary_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "_AcadDictionary_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_Constructor : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8B386FAF-A3D7-4E5C-8F1C-C2646983B4B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.AcadDictionary_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "_AcadDictionary_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_ConstructorCast : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3589949D-D4E0-48F7-9C9B-BC4F7BD70173", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]

	///<summary>
	///Specifies or returns the name of a dictionary.
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
		Id = "735A7C63-6C04-40FA-97A0-F21D45E734C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a dictionary.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a dictionary.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B12018B-8A9F-4044-BA67-F3D6ACC1DE8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.AddObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "AddObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds an object to a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]
	[NodeInput("ObjectName", typeof(System.String))]

	///<summary>
	///Adds an object to a dictionary.
	///</summary>
	public class AddObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddObject(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C35F5920-7B70-4D55-A256-F2EE54AF6DD1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.GetName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "GetName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the keyword string of an object in a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]

	///<summary>
	///Returns the keyword string of an object in a dictionary.
	///</summary>
	public class GetName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "C3D90370-DFEE-45D4-880E-C9E588AA0B79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.GetObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "GetObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object in a dictionary using the keyword string associated with the object.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Returns an object in a dictionary using the keyword string associated with the object.
	///</summary>
	public class GetObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DD20ADCA-081A-4D33-8EB1-AC6A32EC6932", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes an object from a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Deletes an object from a dictionary.
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Remove(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5E1F5887-E376-4EE7-9503-FC3F6A13BDC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Rename", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Rename", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Renames an object in a dictionary.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("NewName", typeof(System.String))]

	///<summary>
	///Renames an object in a dictionary.
	///</summary>
	public class Rename : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rename(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78BA0878-0CDE-492B-9657-7B6641A003E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Replace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Replace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Replaces an object in a dictionary with another object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("pObj", typeof(System.Object))]

	///<summary>
	///Replaces an object in a dictionary with another object.
	///</summary>
	public class Replace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Replace(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7A0FFFA5-3D97-4D71-9D3B-DA093A985226", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object in a dictionary using the index associated with the object.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object in a dictionary using the index associated with the object.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "63DE16CC-57ED-4006-9CE0-FCDD9914898D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of objects in a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]

	///<summary>
	///Returns the number of objects in a dictionary.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "E510A08D-BAAA-414D-923F-6799B91F1AEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDictionary.AddXRecord", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDictionary", 
		NodeName = "AddXRecord", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds an XRecord object to a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]

	///<summary>
	///Adds an XRecord object to a dictionary.
	///</summary>
	public class AddXRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddXRecord(inputs[1].Value));

		}
	}
}
