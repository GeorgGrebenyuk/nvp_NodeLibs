using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IBOM interface
///</summary>
namespace McCOM2.BOM 
{

	[NVP_Manifest(
		Id = "BC512A6A-4293-430B-A473-40153EA8B768", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.BOM_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "_BOM_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOM_Constructor : INode 
	{
		public McCOM2.IBOM _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOM;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9C534310-26C3-46E5-A3B7-8C4E1B9781C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.BOM_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "_BOM_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOM_ConstructorCast : INode 
	{
		public McCOM2.IBOM _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOM;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1D07E4E9-7950-440D-A6AC-A81037603896", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ba", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005ba
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
		Id = "944B0C3A-6FBE-41DB-BFC9-1294BC0F811D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005bb", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bb
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
		Id = "770004FF-7BF5-4F0A-B2F3-B0E7E88CDC55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.CreateRecord", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "CreateRecord", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005bc", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bc
	///</summary>
	public class CreateRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateRecord);

		}
	}


	[NVP_Manifest(
		Id = "DBB4DA99-C0B3-4CE9-BA22-DDE6CFFEDC7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.RemoveRecord", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "RemoveRecord", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005bd", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005bd
	///</summary>
	public class RemoveRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveRecord(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C35F60B2-804C-4446-9970-4D0E416B4BDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Style", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Style", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005be", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005be
	///</summary>
	public class Style : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Style);

		}
	}


	[NVP_Manifest(
		Id = "B6E05D72-0091-471F-91A1-49020B250417", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Set_Style", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Set_Style", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005be", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000005be
	///</summary>
	public class Set_Style : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Style = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2EE92176-8D52-4167-9FC5-8A8F938F96E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Sections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Sections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005bf", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bf
	///</summary>
	public class Sections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sections);

		}
	}


	[NVP_Manifest(
		Id = "C5C00546-AFDF-4A3E-B7CF-A99B7412839C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Edit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Edit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c0", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005c0
	///</summary>
	public class Edit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Edit();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "978022E9-E471-4E8F-AA21-61FFE0439754", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c1", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("fUpdateRelatedObjects", typeof(System.Object))]

	///<summary>
	///0x000005c1
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "49E2EBCE-DC10-4A00-B5C7-287C6447B588", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Sort", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Sort", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c7", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("bstrPartition", typeof(System.String))]
	[NodeInput("iBomPerformance", typeof(System.Object))]

	///<summary>
	///0x000005c7
	///</summary>
	public class Sort : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sort(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "711CF47F-4CE1-43E5-9618-E7AF0F679670", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Renumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Renumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d7", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005d7
	///</summary>
	public class Renumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Renumber();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D68D55C0-1B52-466E-80EF-CC83770EC44E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOM.Export", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOM", 
		NodeName = "Export", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c3", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("McCOM2.BOMExportFormat", typeof(System.Object))]
	[NodeInput("vParams", typeof(System.Object))]

	///<summary>
	///0x000005c3
	///</summary>
	public class Export : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Export(((McCOM2.BOMExportFormat)inputs[1].Value),inputs[2].Value);
			return null;
		}
	}
}
