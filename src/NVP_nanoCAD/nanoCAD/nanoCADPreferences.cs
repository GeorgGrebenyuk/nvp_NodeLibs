using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferences 
{
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


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Returns the PreferencesFiles object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Files : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Files);

			}
		}


		///<summary>
		///Returns the PreferencesDisplay object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Display : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Display);

			}
		}


		///<summary>
		///Returns the PreferencesOpenSave object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class OpenSave : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OpenSave);

			}
		}


		///<summary>
		///Returns the PreferencesOutput object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Output : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Output);

			}
		}


		///<summary>
		///Returns the PreferencesSystem object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class System : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.System);

			}
		}


		///<summary>
		///Returns the PreferencesUser object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class User : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.User);

			}
		}


		///<summary>
		///Returns the PreferencesDrafting object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Drafting : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Drafting);

			}
		}


		///<summary>
		///Returns the PreferencesSelection object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Selection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Selection);

			}
		}


		///<summary>
		///Returns the PreferencesProfiles object.
		///</summary>
		[NodeInput("nanoCADPreferences", typeof(object))]
		public class Profiles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Profiles);

			}
		}
}
