using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesProfiles 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPreferencesProfiles_Constructor : INode 
		{
		public nanoCAD.InanoCADPreferencesProfiles _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPreferencesProfiles;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPreferencesProfiles_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPreferencesProfiles _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPreferencesProfiles;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the Application object
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns the current profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_ActiveProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ActiveProfile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		public class ActiveProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ActiveProfile);

			}
		}


		///<summary>
		///Imports a profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("ProfileName", typeof(System.String))]
		[NodeInput("RegFile", typeof(System.String))]
		[NodeInput("IncludePathInfo", typeof(System.Object))]
		public class ImportProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImportProfile(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Exports the current profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("ProfileName", typeof(System.String))]
		[NodeInput("RegFile", typeof(System.String))]
		public class ExportProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExportProfile(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Deletes a profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("ProfileName", typeof(System.String))]
		public class DeleteProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DeleteProfile(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Resets profile values to their default values.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("Profile", typeof(System.String))]
		public class ResetProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ResetProfile(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Renames a profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("origProfileName", typeof(System.String))]
		[NodeInput("newProfileName", typeof(System.String))]
		public class RenameProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RenameProfile(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Copies a profile.
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("oldProfileName", typeof(System.String))]
		[NodeInput("newProfileName", typeof(System.String))]
		public class CopyProfile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CopyProfile(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Gets all available profiles for the system
		///</summary>
		[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
		[NodeInput("pNames", typeof(System.Object))]
		public class GetAllProfileNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetAllProfileNames(inputs[1]);
				return null;
			}
		}
}
