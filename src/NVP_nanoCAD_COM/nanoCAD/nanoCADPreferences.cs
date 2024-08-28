using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPreferences 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferences_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferences_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferences _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferences;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the Application object.
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
		Text = "Returns the PreferencesFiles object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesFiles object.
	///</summary>
	public class Files : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Files);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesDisplay object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesDisplay object.
	///</summary>
	public class Display : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Display);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesOpenSave object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesOpenSave object.
	///</summary>
	public class OpenSave : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenSave);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesOutput object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesOutput object.
	///</summary>
	public class Output : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Output);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesSystem object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesSystem object.
	///</summary>
	public class System : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.System);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesUser object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesUser object.
	///</summary>
	public class User : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.User);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesDrafting object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesDrafting object.
	///</summary>
	public class Drafting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Drafting);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesSelection object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesSelection object.
	///</summary>
	public class Selection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Selection);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PreferencesProfiles object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferences", typeof(object))]

	///<summary>
	///Returns the PreferencesProfiles object.
	///</summary>
	public class Profiles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profiles);

		}
	}
}
