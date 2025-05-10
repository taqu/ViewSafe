using System.Diagnostics;

namespace ViewSafe
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void OnDragDrop(object sender, DragEventArgs e)
		{
			if (sender == PanelDropFile && e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (filenames.Length <= 0)
				{
					return;
				}
				ToolStripStatusMain.Text = string.Format("Dropped file is {0}", filenames[0]);
				DumpSafeTensors(filenames[0]);
			}
		}

		private void OnDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private Tensors? tensors_ = null;
		private void DumpSafeTensors(string path)
		{
			Tensors? tensors = Tensors.Open(path);
			if (null == tensors) {
				return;
			}
			tensors_ = tensors;
			ListViewMetadata.Items.Clear();
			for (int i=0; i< tensors_.num_metadata(); ++i)
			{
				ListViewItem item = new ListViewItem(new string[] {tensors.get_metadata_key(i), tensors.get_metadata_value(i)});
				ListViewMetadata.Items.Add(item);
				Debug.Print("{0} = {1}", tensors.get_metadata_key(i), tensors.get_metadata_value(i));
			}
			ListViewTensors.Items.Clear();
			for (int i = 0; i < tensors.num_tensors(); ++i)
			{
				Tensor tensor = tensors.get_tensor(i);
				ListViewItem item = new ListViewItem(new string[] { tensor.name_, tensor.dtype_.ToString(), string.Format("{0}x{1}x{2}x{3}", tensor.shape0_, tensor.shape1_, tensor.shape2_, tensor.shape3_)});
				ListViewTensors.Items.Add(item);
				Debug.Print("[{0}] {1} type:{2}, dim:{3}x{4}x{5}x{6}", i, tensor.name_, tensor.dtype_, tensor.shape0_, tensor.shape1_, tensor.shape2_, tensor.shape3_);
			}
		}
	}
}
