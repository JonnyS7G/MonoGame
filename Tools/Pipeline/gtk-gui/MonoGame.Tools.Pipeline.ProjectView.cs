
// This file has been generated by the GUI designer. Do not modify.
namespace MonoGame.Tools.Pipeline
{
	internal partial class ProjectView
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeview1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoGame.Tools.Pipeline.ProjectView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoGame.Tools.Pipeline.ProjectView";
			// Container child MonoGame.Tools.Pipeline.ProjectView.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView ();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.treeview1.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeview1);
			this.Add (this.GtkScrolledWindow);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.treeview1.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnTreeview1ButtonReleaseEvent);
			this.treeview1.CursorChanged += new global::System.EventHandler (this.OnTreeview1CursorChanged);
		}
	}
}
