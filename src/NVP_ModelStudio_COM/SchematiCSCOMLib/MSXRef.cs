using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSXRef Interface
///</summary>
namespace SchematiCSCOMLib.MSXRef 
{

	[NVP_Manifest(
		Id = "F1B2756B-2730-4833-9F4F-6738B62DC202", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.MSXRef_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "_MSXRef_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSXRef_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D742EC29-43C7-4915-9A76-63373014EA2C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.MSXRef_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "_MSXRef_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSXRef_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "924A710C-924F-4E68-86CC-F1F68C2FD1AC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "F4EEE711-B087-456B-8864-5679A76B98ED", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A3F7A38A-6296-4FFE-BBAC-7122285F0BC2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.Destination", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "Destination", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Назначение", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Назначение
	///</summary>
	public class Destination : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Destination);

		}
	}


	[NVP_Manifest(
		Id = "E5EF4618-A0BF-48B2-88BC-159EA4A715DC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.Set_Destination", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "Set_Destination", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Назначение", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Назначение
	///</summary>
	public class Set_Destination : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Destination = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0668499E-902A-44A1-BDF2-860D7EF0BD74", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.NameSelf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "NameSelf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имя текущей ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Имя текущей ссылки
	///</summary>
	public class NameSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameSelf);

		}
	}


	[NVP_Manifest(
		Id = "4893562A-057B-4D26-82DB-8374886D2529", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.Set_NameSelf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "Set_NameSelf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имя текущей ссылки", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Имя текущей ссылки
	///</summary>
	public class Set_NameSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NameSelf = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24E3B7D5-69D5-4D37-9933-61504BE40B99", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.BindState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "BindState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Состояние ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Состояние ссылки
	///</summary>
	public class BindState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BindState);

		}
	}


	[NVP_Manifest(
		Id = "C3CDE288-84C0-4DF3-A9F6-A7D215CC6E03", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.HandleSelf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "HandleSelf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Handle текущей ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Handle текущей ссылки
	///</summary>
	public class HandleSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleSelf);

		}
	}


	[NVP_Manifest(
		Id = "124C7E9E-61B7-4395-8A62-1C57584EDF7A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSXRef.HandleTo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSXRef", 
		NodeName = "HandleTo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Handle другой ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Handle другой ссылки
	///</summary>
	public class HandleTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleTo);

		}
	}
}
