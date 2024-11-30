using firstExam.Models;

namespace firstExam.Service;

internal class PhoneService
{
    private List<Phone> phones;

    public PhoneService()
    {
        var phones = new List<Phone>();

    }

    public Phone AddPhone(Phone newPhone)
    {
        newPhone.Id = Guid.NewGuid();
        phones.Add(newPhone);

        return newPhone;
    }


    public Phone GetById(Guid id)
    {
        foreach (Phone phoneDb in phones)
        {
            if (phoneDb.Id == id)
            {
                return phoneDb;
            }
        }
        return null;
    }

    public bool DeletePhone(Guid id)
    {
        var phoneFormat = GetById(id);

        if (phoneFormat is null)
        {
            return false;
        }

        phones.Remove(phoneFormat);
        return true;
    }

    public bool UpdatePhone(Guid id)
    {
        var phoneFormat = GetById(id);

        if (phoneFormat is null)
        {
            return false;
        }

        var index = phones.IndexOf(phoneFormat);
        phones[index] = phoneFormat;
        return true;
    }

    public List<Phone> GetAll()
    {
        return phones;
    }


}
