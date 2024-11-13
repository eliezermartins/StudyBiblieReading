using Microsoft.Extensions.DependencyInjection;
using StudyBibleReading.App.Services;

namespace StudyBibleReading.WinForms;

public partial class MainForm : Form
{
    private PublisherService publisherService = null!;
    private TranslationService translationsService = null!;

    public MainForm()
    {
        publisherService = ServiceLocator.GetService<PublisherService>();
        translationsService = ServiceLocator.GetService<TranslationService>();
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var publishers = publisherService.GetAll().Result;
        var translations = translationsService.GetAll().Result;
    }
}
