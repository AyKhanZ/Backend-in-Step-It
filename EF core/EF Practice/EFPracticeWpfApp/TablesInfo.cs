using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EFPracticeWpfApp;
public static class TablesInfo
{
    public static AcademyContext context = new();
    private static ObservableCollection<string> list = new();
    public static ObservableCollection<string> ShowDepartment()
    {
        list.Clear();
        context.Database.EnsureCreated(); 
        context.Teachers.Load(); 
        var db = context.Teachers.Local.ToObservableCollection();
        foreach (var item in db) list.Add(item.Name);
        return list;
    }
    public static ObservableCollection<string> ShowFaculty()
    {
        list.Clear();
        context.Database.EnsureCreated();
        context.Faculties.Load();
        var db = context.Faculties.Local.ToObservableCollection();
        foreach (var item in db) list.Add(item.Name);
        return list;
    }
    public static ObservableCollection<string> ShowTeachers()
    {
        list.Clear();
        context.Database.EnsureCreated();
        context.Teachers.Load();
        var db = context.Teachers.Local.ToObservableCollection();
        foreach (var item in db) list.Add(item.Name);
        return list;
    }
    public static ObservableCollection<string> ShowGroup()
    {
        list.Clear();
        context.Database.EnsureCreated();
        context.Groups.Load();
        var db = context.Groups.Local.ToObservableCollection();
        foreach (var item in db) list.Add(item.Name);
        return list;
    }
    public static ObservableCollection<string> ShowSubjects()
    {
        list.Clear();
        // гарантируем, что база данных создана
        context.Database.EnsureCreated();
        // загружаем данные из БД
        context.Subjects.Load();
        // и устанавливаем данные в качестве контекста
        var db = context.Subjects.Local.ToObservableCollection();
        foreach (var item in db) list.Add(item.Name);
        return list;
    }
}


