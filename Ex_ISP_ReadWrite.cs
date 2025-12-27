using System;

namespace Ex_ISP_ReadWrite
{
    // ✅ ISP: split big interface into smaller ones.
    public interface IRead
    {
        void Read();
    }

    public interface IWrite
    {
        void Write();
    }

    public class SecureAccount : IRead, IWrite
    {
        public void Read() => Console.WriteLine("Reading secure account balance...");
        public void Write() => Console.WriteLine("Updating secure account balance...");
    }

    public class ReadOnlyAccount : IRead
    {
        // ✅ ISP benefit: ReadOnlyAccount is NOT forced to implement Write().
        public void Read() => Console.WriteLine("Reading (read-only) account balance...");
    }

    class Program
    {
        static void Main()
        {
            IRead ro = new ReadOnlyAccount();
            ro.Read();

            SecureAccount sa = new SecureAccount();
            sa.Read();
            sa.Write();

            Console.ReadKey();
        }
    }
}

/*
SOLID Link:
- ISP: Clients should not be forced to depend on methods they do not use.
*/
