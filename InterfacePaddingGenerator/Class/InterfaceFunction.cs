using System.Windows.Forms;

namespace IPG.Class
{
    public class InterfaceFunction
    {
        /// <summary>
        /// Constuctor for InterfaceFunction
        /// </summary>
        /// <param name="Index">Value to initialize the Index member</param>
        /// <param name="FunctionSignature">Value to initialize the FunctionSignature member</param>
        /// <param name="LVIInstance">Value to initialize the LVIInstance member</param>
        public InterfaceFunction(int Index, string FunctionSignature, ListViewItem LVIInstance = null)
        {
            this.Index = Index;
            this.FunctionSignature = FunctionSignature;
            this.LVIInstance = LVIInstance;
        }

        /// <summary>
        /// Index of the interface function
        /// </summary>
        public int Index = -1;

        /// <summary>
        /// Function signature of the defined interface function
        /// </summary>
        public string FunctionSignature = null;

        /// <summary>
        /// Current LVI instance reference to the main form's list view
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public ListViewItem LVIInstance = null;
    }
}
