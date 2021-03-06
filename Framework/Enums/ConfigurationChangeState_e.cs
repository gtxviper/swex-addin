//**********************
//SwEx.AddIn - development tools for SOLIDWORKS add-ins
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/add-in/
//**********************

namespace CodeStack.SwEx.AddIn.Enums
{
    /// <summary>
    /// States of configuration or sheet changes
    /// </summary>
    public enum ConfigurationChangeState_e
    {
        /// <summary>
        /// Configuration is about to be activated
        /// </summary>
        /// <remarks>Pre activate for drawing sheets supported from SOLIDWORKS 2013 (revision 21.0)</remarks>
        PreActivate,

        /// <summary>
        /// Configuration has been activated
        /// </summary>
        PostActivate
    }
}