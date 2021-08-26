using Helga_portfolio.Domain.Repositories.Abstract;

namespace Helga_portfolio.Domain.Repositories {
    public class DataManager {

        public ITextFieldsRepository TextFields { get; set; }
        public ISinglePhotoRepository SinglePhotos { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, ISinglePhotoRepository serviceItemsRepository) {
            TextFields = textFieldsRepository;
            SinglePhotos = serviceItemsRepository;
        }
    }
}
