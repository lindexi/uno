using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.UI.Samples.Controls;
using Uno.UI.Samples.UITests.Helpers;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace UITests.Shared.Windows_Storage.Pickers
{
	[Sample("Windows.Storage", ViewModelType = typeof(FileSavePickerTestsViewModel))]
	public sealed partial class FileSavePickerTests : Page
	{
		public FileSavePickerTests()
		{
			InitializeComponent();
			this.DataContextChanged += FolderPickerTests_DataContextChanged;
		}

		private void FolderPickerTests_DataContextChanged(Windows.UI.Xaml.FrameworkElement sender, Windows.UI.Xaml.DataContextChangedEventArgs args)
		{
			ViewModel = args.NewValue as FileSavePickerTestsViewModel;
		}

		public FileSavePickerTestsViewModel ViewModel { get; private set; }
	}

	public class FileSavePickerTestsViewModel : ViewModelBase
	{
		private string _errorMessage = string.Empty;
		private string _statusMessage = string.Empty;
		private string _suggestedFileName = string.Empty;
		private string _fileChoiceExtension = string.Empty;

		private StorageFile _suggestedSaveFile = null;
		private StorageFile _pickedFile = null;
		private FileTypeChoiceViewModel _newFileTypeChoice = new FileTypeChoiceViewModel();
		private FileTypeChoiceViewModel _selectedFileTypeChoice = null;

		public FileSavePickerTestsViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public PickerLocationId[] SuggestedStartLocations { get; } = Enum.GetValues(typeof(PickerLocationId)).OfType<PickerLocationId>().ToArray();

		public PickerLocationId SuggestedStartLocation { get; set; } = PickerLocationId.ComputerFolder;

		public string SettingsIdentifier { get; set; } = string.Empty;

		public string CommitButtonText { get; set; } = string.Empty;

		public PickerViewMode[] ViewModes { get; } = Enum.GetValues(typeof(PickerViewMode)).OfType<PickerViewMode>().ToArray();

		public PickerViewMode ViewMode { get; set; } = PickerViewMode.List;

		public string ErrorMessage
		{
			get => _errorMessage;
			set
			{
				_errorMessage = value;
				RaisePropertyChanged();
			}
		}

		public string SuggestedFileName
		{
			get => _suggestedFileName;
			set
			{
				_suggestedFileName = value;
				RaisePropertyChanged();
			}
		}

		public StorageFile SuggestedSaveFile
		{
			get => _suggestedSaveFile;
			set
			{
				_suggestedSaveFile = value;
				RaisePropertyChanged();
			}
		}

		public string StatusMessage
		{
			get => _statusMessage;
			set
			{
				_statusMessage = value;
				RaisePropertyChanged();
			}
		}

		public FileTypeChoiceViewModel NewFileTypeChoice
		{
			get => _newFileTypeChoice;
			set
			{
				_newFileTypeChoice = value;
				RaisePropertyChanged();
			}
		}

		public ObservableCollection<FileTypeChoiceViewModel> FileTypeChoices { get; } = new ObservableCollection<FileTypeChoiceViewModel>();

		public FileTypeChoiceViewModel SelectedFileTypeChoice
		{
			get => _selectedFileTypeChoice;
			set
			{
				_selectedFileTypeChoice = value;
				RaisePropertyChanged();
			}
		}

		public string FileChoiceExtension
		{
			get => _fileChoiceExtension;
			set
			{
				_fileChoiceExtension = value;
				RaisePropertyChanged();
			}
		}

		public void AddFileTypeChoice()
		{
			if (!string.IsNullOrEmpty(NewFileTypeChoice.Name) && NewFileTypeChoice.Extensions.Count > 0)
			{
				FileTypeChoices.Add(NewFileTypeChoice);
				NewFileTypeChoice = new FileTypeChoiceViewModel();
			}
		}

		public void AddFileChoiceExtension()
		{
			if (!string.IsNullOrEmpty(FileChoiceExtension))
			{
				NewFileTypeChoice.Extensions.Add(FileChoiceExtension);
				NewFileTypeChoice.RaiseDescriptionChanged();
				FileChoiceExtension = string.Empty;
			}
		}

		public void ResetNewFileTypeChoice() => NewFileTypeChoice = new FileTypeChoiceViewModel();

		public void RemoveSelectedFileTypeChoice()
		{
			if (SelectedFileTypeChoice != null)
			{
				FileTypeChoices.Remove(SelectedFileTypeChoice);
			}
		}

		public StorageFile PickedFile
		{
			get => _pickedFile;
			set
			{
				_pickedFile = value;
				RaisePropertyChanged();
			}
		}

		public async void PickSuggestedSaveFile()
		{
			ErrorMessage = string.Empty;
			try
			{
				var fileOpenPicker = new FileOpenPicker()
				{
					SuggestedStartLocation = PickerLocationId.ComputerFolder,
					FileTypeFilter = {"*"}
				};
				SuggestedSaveFile = await fileOpenPicker.PickSingleFileAsync();
			}
			catch (Exception ex)
			{
				ErrorMessage = $"Exception occurred: {ex}.";
			}
		}

		public void ClearSuggestedSaveFile() => SuggestedSaveFile = null;

		public async void PickSaveFile()
		{
			ErrorMessage = string.Empty;
			StatusMessage = string.Empty;
			try
			{
				var fileSavePicker = new FileSavePicker
				{
					SuggestedStartLocation = SuggestedStartLocation,
				};
				if (!string.IsNullOrEmpty(SettingsIdentifier))
				{
					fileSavePicker.SettingsIdentifier = SettingsIdentifier;
				}
				if (!string.IsNullOrEmpty(CommitButtonText))
				{
					fileSavePicker.CommitButtonText = CommitButtonText;
				}
				if (!string.IsNullOrEmpty(SuggestedFileName))
				{
					fileSavePicker.SuggestedFileName = SuggestedFileName;
				}
				foreach (var fileTypeChoice in FileTypeChoices)
				{
					fileSavePicker.FileTypeChoices.Add(fileTypeChoice.Name, fileTypeChoice.Extensions);
				}
				var pickedFile = await fileSavePicker.PickSaveFileAsync();
				StatusMessage = "Folder picked successfully.";
				PickedFile = pickedFile;
			}
			catch (Exception ex)
			{
				ErrorMessage = $"Exception occurred: {ex}.";
			}
		}
	}

	public class FileTypeChoiceViewModel : ViewModelBase
	{
		private string _name = string.Empty;

		public FileTypeChoiceViewModel()
		{
		}

		public FileTypeChoiceViewModel(string name, string[] extensions) =>
			(Name, Extensions) = (name, new ObservableCollection<string>(extensions));

		public string Name
		{
			get => _name;
			set
			{
				_name = value;
				RaisePropertyChanged();
				RaiseDescriptionChanged();
			}
		}

		public ObservableCollection<string> Extensions { get; } = new ObservableCollection<string>();

		public string Description => $"{Name} ({string.Join(",", Extensions)})";

		public void RaiseDescriptionChanged()
		{
			RaisePropertyChanged(nameof(Description));
		}
	}
}
