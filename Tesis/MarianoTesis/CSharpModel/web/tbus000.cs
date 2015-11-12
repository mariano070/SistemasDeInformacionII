/*
               File: TBUS000
        Description: ACT. DE BIENES DE USO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:49.23
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tbus000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action41") == 0 )
         {
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            A8BUS_EMP = GetNextPar( ) ;
            n8BUS_EMP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_41_0O24( Gx_mode, A8BUS_EMP) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action55") == 0 )
         {
            A8BUS_EMP = GetNextPar( ) ;
            n8BUS_EMP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A3BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n3BUS_COD = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            A4BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n4BUS_PAR = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_55_0O24( A8BUS_EMP, A1BUS_RUB, A3BUS_COD, A4BUS_PAR, Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action57") == 0 )
         {
            A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A54BUS_DES = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            A170BUS_FAL = context.localUtil.ParseDateParm( GetNextPar( )) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            A55BUS_FAD = context.localUtil.ParseDateParm( GetNextPar( )) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            A333BUS_NCO = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            A331BUS_COM = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_57_0O24( A1BUS_RUB, A54BUS_DES, A170BUS_FAL, A55BUS_FAD, A333BUS_NCO, A331BUS_COM) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action58") == 0 )
         {
            A8BUS_EMP = GetNextPar( ) ;
            n8BUS_EMP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A3BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n3BUS_COD = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            A4BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n4BUS_PAR = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            A103BUS_IDT = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_58_0O24( A8BUS_EMP, A1BUS_RUB, A3BUS_COD, A4BUS_PAR, A103BUS_IDT) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action60") == 0 )
         {
            A103BUS_IDT = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            A174BUS_FBA = context.localUtil.ParseDateParm( GetNextPar( )) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_60_0O24( A103BUS_IDT, A174BUS_FBA) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_63") == 0 )
         {
            A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_63( A1BUS_RUB) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            Gx_mode = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV8BUS_EMP = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BUS_EMP", AV8BUS_EMP);
               AV11BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11BUS_RUB), 4, 0)));
               AV7BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BUS_COD), 4, 0)));
               AV10BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BUS_PAR), 2, 0)));
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. DE BIENES DE USO", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBUS_EMP_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tbus000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_BUS_EMP ,
                           short aP2_BUS_RUB ,
                           short aP3_BUS_COD ,
                           short aP4_BUS_PAR )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV8BUS_EMP = aP1_BUS_EMP;
         this.AV11BUS_RUB = aP2_BUS_RUB;
         this.AV7BUS_COD = aP3_BUS_COD;
         this.AV10BUS_PAR = aP4_BUS_PAR;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"ACT. DE BIENES DE USO"+"</legend>") ;
            wb_table3_27_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0O24e( true) ;
         }
         else
         {
            wb_table1_2_0O24e( false) ;
         }
      }

      protected void wb_table3_27_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "DATOS PROCESOS ACTUALIZACION", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_136_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table5_136_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 220,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TBUS000.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 221,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TBUS000.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 222,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0O24e( true) ;
         }
         else
         {
            wb_table3_27_0O24e( false) ;
         }
      }

      protected void wb_table5_136_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTableprocesos_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTableprocesos_Internalname, tblTableprocesos_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table6_139_0O24( true) ;
         }
         return  ;
      }

      protected void wb_table6_139_0O24e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_136_0O24e( true) ;
         }
         else
         {
            wb_table5_136_0O24e( false) ;
         }
      }

      protected void wb_table6_139_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fpr_Internalname, 1, 1, 0, "FECHA DE PROCESO AJUSTE", "", "", "", 0, lblTextblockbus_fpr_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FPR_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FPR_Internalname, context.localUtil.Format(A340BUS_FPR, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_FPR_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A340BUS_FPR, "99/99/9999"), "", 0, edtBUS_FPR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FPR_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_FPR_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vut_Internalname, 1, 1, 0, "VIDA UTIL TRANSCURRIDA", "", "", "", 0, lblTextblockbus_vut_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUT_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A335BUS_VUT), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_VUT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A335BUS_VUT), "ZZZ9"), "", 0, edtBUS_VUT_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_coe_Internalname, 1, 1, 0, "ULTIMO COEFICIENTE DE CALCULO", "", "", "", 0, lblTextblockbus_coe_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COE_Internalname, StringUtil.LTrim( StringUtil.NToC( A336BUS_COE, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_COE_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A336BUS_COE, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_COE_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_voc_Internalname, 1, 1, 0, "VALOR ORIGEN AJUSTADO (C)", "", "", "", 0, lblTextblockbus_voc_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOC_Internalname, StringUtil.LTrim( StringUtil.NToC( A341BUS_VOC, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VOC_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A341BUS_VOC, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOC_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_voa_Internalname, 1, 1, 0, "VALOR DE ORIGEN AJUSTADO", "", "", "", 0, lblTextblockbus_voa_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOA_Internalname, StringUtil.LTrim( StringUtil.NToC( A337BUS_VOA, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VOA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A337BUS_VOA, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aaa_Internalname, 1, 1, 0, "AMORTIZ. ACUMULADAS AJUSTADAS", "", "", "", 0, lblTextblockbus_aaa_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AAA_Internalname, StringUtil.LTrim( StringUtil.NToC( A338BUS_AAA, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtBUS_AAA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A338BUS_AAA, "ZZZZZZ9.99"), "", 0, edtBUS_AAA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aea_Internalname, 1, 1, 0, "AMORTIZ. DEL EJERCICIO AJUST.", "", "", "", 0, lblTextblockbus_aea_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AEA_Internalname, StringUtil.LTrim( StringUtil.NToC( A339BUS_AEA, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtBUS_AEA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A339BUS_AEA, "ZZZZZZ9.99"), "", 0, edtBUS_AEA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aea2_Internalname, 1, 1, 0, "VALOR HISTORICO BASE", "", "", "", 0, lblTextblockbus_aea2_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VAH_Internalname, StringUtil.LTrim( StringUtil.NToC( A342BUS_VAH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VAH_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A342BUS_VAH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VAH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aea3_Internalname, 1, 1, 0, "FECHA VALOR HISTORICO BASE", "", "", "", 0, lblTextblockbus_aea3_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_VHF_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VHF_Internalname, context.localUtil.Format(A343BUS_VHF, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_VHF_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A343BUS_VHF, "99/99/9999"), "", 0, edtBUS_VHF_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            GxWebStd.gx_bitmap( context, edtBUS_VHF_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_VHF_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_voh_Internalname, 1, 1, 0, "VALOR DE ORIGEN HISTORICO", "", "", "", 0, lblTextblockbus_voh_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOH_Internalname, StringUtil.LTrim( StringUtil.NToC( A344BUS_VOH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VOH_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A344BUS_VOH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aah_Internalname, 1, 1, 0, "AMORTIZ. ACUMULADAS VAL HISTOR", "", "", "", 0, lblTextblockbus_aah_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AAH_Internalname, StringUtil.LTrim( StringUtil.NToC( A345BUS_AAH, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtBUS_AAH_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A345BUS_AAH, "ZZZZZZ9.99"), "", 0, edtBUS_AAH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aeh_Internalname, 1, 1, 0, "AMORTIZ. DEL EJERCICIO HISTORI", "", "", "", 0, lblTextblockbus_aeh_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AEH_Internalname, StringUtil.LTrim( StringUtil.NToC( A346BUS_AEH, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtBUS_AEH_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A346BUS_AEH, "ZZZZZZ9.99"), "", 0, edtBUS_AEH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vra_Internalname, 1, 1, 0, "VALOR RESIDUAL AJ (FORMULA)", "", "", "", 0, lblTextblockbus_vra_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VRA_Internalname, StringUtil.LTrim( StringUtil.NToC( A347BUS_VRA, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VRA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A347BUS_VRA, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VRA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vrh_Internalname, 1, 1, 0, "VALOR RESIDUAL HIST(FORMULA)", "", "", "", 0, lblTextblockbus_vrh_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VRH_Internalname, StringUtil.LTrim( StringUtil.NToC( A348BUS_VRH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VRH_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A348BUS_VRH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VRH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vur_Internalname, 1, 1, 0, "VIDA UTIL RESIDUAL (FORMULA)", "", "", "", 0, lblTextblockbus_vur_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUR_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A349BUS_VUR), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_VUR_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A349BUS_VUR), "ZZZ9"), "", 0, edtBUS_VUR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_139_0O24e( true) ;
         }
         else
         {
            wb_table6_139_0O24e( false) ;
         }
      }

      protected void wb_table4_33_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_emp_Internalname, 1, 1, 0, "CODIGO DE EMPRESA", "", "", "", 0, lblTextblockbus_emp_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_EMP_Internalname, StringUtil.RTrim( A8BUS_EMP), "", 1, "chr", 1, "row", 1, 1, edtBUS_EMP_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(38);\"", 0, edtBUS_EMP_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_rub_Internalname, 1, 1, 0, "RUBRO DEL BIEN", "", "", "", 0, lblTextblockbus_rub_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_RUB_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_RUB_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtBUS_RUB_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, "", "prompt.gif", "Modern", imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_1_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_cod_Internalname, 1, 1, 0, "CODIGO Y PARTIDA", "", "", "", 0, lblTextblockbus_cod_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtBUS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_PAR_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, edtBUS_PAR_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(49);\"", 0, edtBUS_PAR_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_des_Internalname, 1, 1, 0, "DESCRIPCION DEL BIEN", "", "", "", 0, lblTextblockbus_des_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_DES_Internalname, StringUtil.RTrim( A54BUS_DES), "", 50, "chr", 1, "row", 50, 1, edtBUS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A54BUS_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(54);\"", 0, edtBUS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fal_Internalname, 1, 1, 0, "FECHA DE ALTA DEL BIEN", "", "", "", 0, lblTextblockbus_fal_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FAL_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FAL_Internalname, context.localUtil.Format(A170BUS_FAL, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_FAL_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A170BUS_FAL, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(62);\"", 0, edtBUS_FAL_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FAL_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_FAL_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fad_Internalname, 1, 1, 0, "FECHA DE ADQUISICION DEL BIEN", "", "", "", 0, lblTextblockbus_fad_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FAD_Internalname, context.localUtil.Format(A55BUS_FAD, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_FAD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A55BUS_FAD, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(67);\"", 0, edtBUS_FAD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_FAD_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vua_Internalname, 1, 1, 0, "VIDA UTIL ASIGNADA AL BIEN", "", "", "", 0, lblTextblockbus_vua_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUA_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A329BUS_VUA), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_VUA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A329BUS_VUA), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(72);\"", 0, edtBUS_VUA_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vao_Internalname, 1, 1, 0, "VALOR DE ORIGEN DEL BIEN", "", "", "", 0, lblTextblockbus_vao_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VAO_Internalname, StringUtil.LTrim( StringUtil.NToC( A330BUS_VAO, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, edtBUS_VAO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A330BUS_VAO, "ZZZZZZZZZ9.9999999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, '.',',','7');"+";gx.evt.onblur(77);\"", 0, edtBUS_VAO_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_com_Internalname, 1, 1, 0, "COMPROBANTE DE COMPRA", "", "", "", 0, lblTextblockbus_com_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COM_Internalname, StringUtil.RTrim( A331BUS_COM), "", 2, "chr", 1, "row", 2, 1, edtBUS_COM_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A331BUS_COM, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(85);\"", 0, edtBUS_COM_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_CBD_Internalname, StringUtil.RTrim( A350BUS_CBD), "", 20, "chr", 1, "row", 20, 1, edtBUS_CBD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A350BUS_CBD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(86);\"", 0, edtBUS_CBD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_nco_Internalname, 1, 1, 0, "NUMERO DEL COMP. DE COMPRA", "", "", "", 0, lblTextblockbus_nco_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_NCO_Internalname, StringUtil.RTrim( A333BUS_NCO), "", 12, "chr", 1, "row", 12, 1, edtBUS_NCO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A333BUS_NCO, "999999999999")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(91);\"", 0, edtBUS_NCO_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_sec_Internalname, 1, 1, 0, "AREA A QUE PERTENECE EL BIEN", "", "", "", 0, lblTextblockbus_sec_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_SEC_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BUS_SEC), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, edtBUS_SEC_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A172BUS_SEC), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(99);\"", 0, edtBUS_SEC_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_SED_Internalname, StringUtil.RTrim( A176BUS_SED), "", 30, "chr", 1, "row", 30, 1, edtBUS_SED_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A176BUS_SED, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(100);\"", 0, edtBUS_SED_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_are_Internalname, 1, 1, 0, "SECTOR DE LA EMPRESA", "", "", "", 0, lblTextblockbus_are_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_ARE_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A171BUS_ARE), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_ARE_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A171BUS_ARE), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(105);\"", 0, edtBUS_ARE_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_ARD_Internalname, StringUtil.RTrim( A175BUS_ARD), "", 30, "chr", 1, "row", 30, 1, edtBUS_ARD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A175BUS_ARD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(106);\"", 0, edtBUS_ARD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_tip_Internalname, 1, 1, 0, "CODIGO DE TIPO DE BIEN", "", "", "", 0, lblTextblockbus_tip_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_TIP_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtBUS_TIP_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A56BUS_TIP), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(111);\"", 0, edtBUS_TIP_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_TID_Internalname, StringUtil.RTrim( A59BUS_TID), "", 20, "chr", 1, "row", 20, 1, edtBUS_TID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A59BUS_TID, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(112);\"", 0, edtBUS_TID_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fba_Internalname, 1, 1, 0, "FECHA DE BAJA DEL BIEN", "", "", "", 0, lblTextblockbus_fba_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FBA_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FBA_Internalname, context.localUtil.Format(A174BUS_FBA, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_FBA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A174BUS_FBA, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(120);\"", 0, edtBUS_FBA_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FBA_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_FBA_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_mba_Internalname, 1, 1, 0, "MOTIVO DE BAJA DEL BIEN", "", "", "", 0, lblTextblockbus_mba_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_MBA_Internalname, StringUtil.RTrim( A334BUS_MBA), "", 30, "chr", 1, "row", 30, 1, edtBUS_MBA_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A334BUS_MBA, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(125);\"", 0, edtBUS_MBA_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "ASOCIAR A TRAZABILIDAD", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_IDT_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A103BUS_IDT), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtBUS_IDT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A103BUS_IDT), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(130);\"", 0, edtBUS_IDT_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_103_Internalname, "", "prompt.gif", "Modern", imgprompt_103_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_103_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0O24e( true) ;
         }
         else
         {
            wb_table4_33_0O24e( false) ;
         }
      }

      protected void wb_table2_5_0O24( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00o0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_EMP"+"'), id:'"+"BUS_EMP"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_RUB"+"'), id:'"+"BUS_RUB"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_COD"+"'), id:'"+"BUS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_PAR"+"'), id:'"+"BUS_PAR"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00o0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_EMP"+"'), id:'"+"BUS_EMP"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_RUB"+"'), id:'"+"BUS_RUB"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_COD"+"'), id:'"+"BUS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"BUS_PAR"+"'), id:'"+"BUS_PAR"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0O24e( true) ;
         }
         else
         {
            wb_table2_5_0O24e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110O2 */
         E110O2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
               n8BUS_EMP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_RUB_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_RUB");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_RUB_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A1BUS_RUB = 0 ;
                  n1BUS_RUB = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               }
               else
               {
                  A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
                  n1BUS_RUB = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_COD_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A3BUS_COD = 0 ;
                  n3BUS_COD = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               }
               else
               {
                  A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
                  n3BUS_COD = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_PAR_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_PAR");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_PAR_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A4BUS_PAR = 0 ;
                  n4BUS_PAR = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               }
               else
               {
                  A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
                  n4BUS_PAR = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               }
               A54BUS_DES = StringUtil.Upper( cgiGet( edtBUS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
               if ( context.localUtil.VCDate( cgiGet( edtBUS_FAL_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ALTA DEL BIEN"}), 1, "BUS_FAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_FAL_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A170BUS_FAL = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               }
               else
               {
                  A170BUS_FAL = context.localUtil.CToD( cgiGet( edtBUS_FAL_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtBUS_FAD_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ADQUISICION DEL BIEN"}), 1, "BUS_FAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_FAD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A55BUS_FAD = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               }
               else
               {
                  A55BUS_FAD = context.localUtil.CToD( cgiGet( edtBUS_FAD_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_VUA_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_VUA_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_VUA_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_VUA");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_VUA_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A329BUS_VUA = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
               }
               else
               {
                  A329BUS_VUA = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUA_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_VAO_Internalname), "ZZZZZZZZZ9.9999999") || ( context.localUtil.CToN( cgiGet( edtBUS_VAO_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_VAO_Internalname), ",", ".") > 9999999999.9999999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_VAO");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_VAO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A330BUS_VAO = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
               }
               else
               {
                  A330BUS_VAO = context.localUtil.CToN( cgiGet( edtBUS_VAO_Internalname), ",", ".") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
               }
               A331BUS_COM = StringUtil.Upper( cgiGet( edtBUS_COM_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
               A350BUS_CBD = StringUtil.Upper( cgiGet( edtBUS_CBD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
               A333BUS_NCO = cgiGet( edtBUS_NCO_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_SEC_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtBUS_SEC_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_SEC_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_SEC");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_SEC_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A172BUS_SEC = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
               }
               else
               {
                  A172BUS_SEC = (short)(context.localUtil.CToN( cgiGet( edtBUS_SEC_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
               }
               A176BUS_SED = StringUtil.Upper( cgiGet( edtBUS_SED_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_ARE_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_ARE_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_ARE_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_ARE");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_ARE_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A171BUS_ARE = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
               }
               else
               {
                  A171BUS_ARE = (short)(context.localUtil.CToN( cgiGet( edtBUS_ARE_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
               }
               A175BUS_ARD = StringUtil.Upper( cgiGet( edtBUS_ARD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_TIP_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_TIP");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_TIP_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A56BUS_TIP = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               }
               else
               {
                  A56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               }
               A59BUS_TID = StringUtil.Upper( cgiGet( edtBUS_TID_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
               if ( context.localUtil.VCDate( cgiGet( edtBUS_FBA_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE BAJA DEL BIEN"}), 1, "BUS_FBA");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_FBA_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A174BUS_FBA = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
               }
               else
               {
                  A174BUS_FBA = context.localUtil.CToD( cgiGet( edtBUS_FBA_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
               }
               A334BUS_MBA = cgiGet( edtBUS_MBA_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_IDT_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_IDT_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_IDT_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_IDT");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_IDT_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A103BUS_IDT = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               }
               else
               {
                  A103BUS_IDT = (int)(context.localUtil.CToN( cgiGet( edtBUS_IDT_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               }
               A340BUS_FPR = context.localUtil.CToD( cgiGet( edtBUS_FPR_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
               A335BUS_VUT = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUT_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
               A336BUS_COE = context.localUtil.CToN( cgiGet( edtBUS_COE_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
               A341BUS_VOC = context.localUtil.CToN( cgiGet( edtBUS_VOC_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
               A337BUS_VOA = context.localUtil.CToN( cgiGet( edtBUS_VOA_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
               A338BUS_AAA = context.localUtil.CToN( cgiGet( edtBUS_AAA_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
               A339BUS_AEA = context.localUtil.CToN( cgiGet( edtBUS_AEA_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
               A342BUS_VAH = context.localUtil.CToN( cgiGet( edtBUS_VAH_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
               A343BUS_VHF = context.localUtil.CToD( cgiGet( edtBUS_VHF_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
               A344BUS_VOH = context.localUtil.CToN( cgiGet( edtBUS_VOH_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
               A345BUS_AAH = context.localUtil.CToN( cgiGet( edtBUS_AAH_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
               A346BUS_AEH = context.localUtil.CToN( cgiGet( edtBUS_AEH_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
               A347BUS_VRA = context.localUtil.CToN( cgiGet( edtBUS_VRA_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
               A348BUS_VRH = context.localUtil.CToN( cgiGet( edtBUS_VRH_Internalname), ",", ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
               A349BUS_VUR = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUR_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
               /* Read saved values. */
               Z8BUS_EMP = cgiGet( "Z8BUS_EMP") ;
               Z1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( "Z1BUS_RUB"), ",", ".")) ;
               Z3BUS_COD = (short)(context.localUtil.CToN( cgiGet( "Z3BUS_COD"), ",", ".")) ;
               Z4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( "Z4BUS_PAR"), ",", ".")) ;
               Z54BUS_DES = cgiGet( "Z54BUS_DES") ;
               Z170BUS_FAL = context.localUtil.CToD( cgiGet( "Z170BUS_FAL"), 0) ;
               Z55BUS_FAD = context.localUtil.CToD( cgiGet( "Z55BUS_FAD"), 0) ;
               Z333BUS_NCO = cgiGet( "Z333BUS_NCO") ;
               Z331BUS_COM = cgiGet( "Z331BUS_COM") ;
               Z171BUS_ARE = (short)(context.localUtil.CToN( cgiGet( "Z171BUS_ARE"), ",", ".")) ;
               Z172BUS_SEC = (short)(context.localUtil.CToN( cgiGet( "Z172BUS_SEC"), ",", ".")) ;
               Z56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( "Z56BUS_TIP"), ",", ".")) ;
               Z329BUS_VUA = (short)(context.localUtil.CToN( cgiGet( "Z329BUS_VUA"), ",", ".")) ;
               Z330BUS_VAO = context.localUtil.CToN( cgiGet( "Z330BUS_VAO"), ",", ".") ;
               Z350BUS_CBD = cgiGet( "Z350BUS_CBD") ;
               Z175BUS_ARD = cgiGet( "Z175BUS_ARD") ;
               Z176BUS_SED = cgiGet( "Z176BUS_SED") ;
               Z59BUS_TID = cgiGet( "Z59BUS_TID") ;
               Z174BUS_FBA = context.localUtil.CToD( cgiGet( "Z174BUS_FBA"), 0) ;
               Z334BUS_MBA = cgiGet( "Z334BUS_MBA") ;
               Z340BUS_FPR = context.localUtil.CToD( cgiGet( "Z340BUS_FPR"), 0) ;
               Z335BUS_VUT = (short)(context.localUtil.CToN( cgiGet( "Z335BUS_VUT"), ",", ".")) ;
               Z336BUS_COE = context.localUtil.CToN( cgiGet( "Z336BUS_COE"), ",", ".") ;
               Z341BUS_VOC = context.localUtil.CToN( cgiGet( "Z341BUS_VOC"), ",", ".") ;
               Z337BUS_VOA = context.localUtil.CToN( cgiGet( "Z337BUS_VOA"), ",", ".") ;
               Z338BUS_AAA = context.localUtil.CToN( cgiGet( "Z338BUS_AAA"), ",", ".") ;
               Z339BUS_AEA = context.localUtil.CToN( cgiGet( "Z339BUS_AEA"), ",", ".") ;
               Z342BUS_VAH = context.localUtil.CToN( cgiGet( "Z342BUS_VAH"), ",", ".") ;
               Z343BUS_VHF = context.localUtil.CToD( cgiGet( "Z343BUS_VHF"), 0) ;
               Z344BUS_VOH = context.localUtil.CToN( cgiGet( "Z344BUS_VOH"), ",", ".") ;
               Z345BUS_AAH = context.localUtil.CToN( cgiGet( "Z345BUS_AAH"), ",", ".") ;
               Z346BUS_AEH = context.localUtil.CToN( cgiGet( "Z346BUS_AEH"), ",", ".") ;
               Z103BUS_IDT = (int)(context.localUtil.CToN( cgiGet( "Z103BUS_IDT"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               N331BUS_COM = cgiGet( "N331BUS_COM") ;
               N171BUS_ARE = (short)(context.localUtil.CToN( cgiGet( "N171BUS_ARE"), ",", ".")) ;
               N172BUS_SEC = (short)(context.localUtil.CToN( cgiGet( "N172BUS_SEC"), ",", ".")) ;
               N56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( "N56BUS_TIP"), ",", ".")) ;
               AV8BUS_EMP = cgiGet( "vBUS_EMP") ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", ".")) ;
               AV11BUS_RUB = (short)(context.localUtil.CToN( cgiGet( "vBUS_RUB"), ",", ".")) ;
               AV7BUS_COD = (short)(context.localUtil.CToN( cgiGet( "vBUS_COD"), ",", ".")) ;
               AV10BUS_PAR = (short)(context.localUtil.CToN( cgiGet( "vBUS_PAR"), ",", ".")) ;
               AV18Insert_BUS_COM = cgiGet( "vINSERT_BUS_COM") ;
               AV17Insert_BUS_ARE = (short)(context.localUtil.CToN( cgiGet( "vINSERT_BUS_ARE"), ",", ".")) ;
               AV19Insert_BUS_SEC = (short)(context.localUtil.CToN( cgiGet( "vINSERT_BUS_SEC"), ",", ".")) ;
               AV20Insert_BUS_TIP = (short)(context.localUtil.CToN( cgiGet( "vINSERT_BUS_TIP"), ",", ".")) ;
               AV16error = (short)(context.localUtil.CToN( cgiGet( "vERROR"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               AV31error_t = (short)(context.localUtil.CToN( cgiGet( "vERROR_T"), ",", ".")) ;
               AV30mensaje = cgiGet( "vMENSAJE") ;
               AV32error_2 = (short)(context.localUtil.CToN( cgiGet( "vERROR_2"), ",", ".")) ;
               A61BUS_RUD = cgiGet( "BUS_RUD") ;
               n61BUS_RUD = false ;
               A178BUS_AMO = cgiGet( "BUS_AMO") ;
               n178BUS_AMO = false ;
               AV34Pgmname = cgiGet( "vPGMNAME") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A8BUS_EMP = GetNextPar( ) ;
                  n8BUS_EMP = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                  A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  n1BUS_RUB = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                  A3BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  n3BUS_COD = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                  A4BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  n4BUS_PAR = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                  getEqualNoModal( ) ;
                  if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8BUS_EMP)) )
                  {
                     A8BUS_EMP = AV8BUS_EMP ;
                     n8BUS_EMP = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A8BUS_EMP)) && ( Gx_BScreen == 0 ) )
                     {
                        A8BUS_EMP = "M" ;
                        n8BUS_EMP = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                     }
                  }
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode24 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8BUS_EMP)) )
                     {
                        A8BUS_EMP = AV8BUS_EMP ;
                        n8BUS_EMP = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A8BUS_EMP)) && ( Gx_BScreen == 0 ) )
                        {
                           A8BUS_EMP = "M" ;
                           n8BUS_EMP = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                        }
                     }
                     Gx_mode = sMode24 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound24 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0O0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "BUS_EMP");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E110O2 */
                           E110O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120O2 */
                           E120O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E120O2 */
            E120O2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0O24( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            imgBtn_delete2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
            imgBtn_delete2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               imgBtn_enter2_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
               imgBtn_enter2_separator_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtBUS_EMP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_EMP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_EMP_Enabled), 5, 0)));
            edtBUS_RUB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_RUB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_RUB_Enabled), 5, 0)));
            edtBUS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COD_Enabled), 5, 0)));
            edtBUS_PAR_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_PAR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_PAR_Enabled), 5, 0)));
            edtBUS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_DES_Enabled), 5, 0)));
            edtBUS_FAL_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FAL_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FAL_Enabled), 5, 0)));
            edtBUS_FAD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FAD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FAD_Enabled), 5, 0)));
            edtBUS_VUA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUA_Enabled), 5, 0)));
            edtBUS_VAO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VAO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VAO_Enabled), 5, 0)));
            edtBUS_COM_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COM_Enabled), 5, 0)));
            edtBUS_CBD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_CBD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_CBD_Enabled), 5, 0)));
            edtBUS_NCO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_NCO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_NCO_Enabled), 5, 0)));
            edtBUS_SEC_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_SEC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_SEC_Enabled), 5, 0)));
            edtBUS_SED_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_SED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_SED_Enabled), 5, 0)));
            edtBUS_ARE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_ARE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_ARE_Enabled), 5, 0)));
            edtBUS_ARD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_ARD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_ARD_Enabled), 5, 0)));
            edtBUS_TIP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_TIP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_TIP_Enabled), 5, 0)));
            edtBUS_TID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_TID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_TID_Enabled), 5, 0)));
            edtBUS_FBA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FBA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FBA_Enabled), 5, 0)));
            edtBUS_MBA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_MBA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_MBA_Enabled), 5, 0)));
            edtBUS_IDT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_IDT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_IDT_Enabled), 5, 0)));
            edtBUS_FPR_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FPR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FPR_Enabled), 5, 0)));
            edtBUS_VUT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUT_Enabled), 5, 0)));
            edtBUS_COE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COE_Enabled), 5, 0)));
            edtBUS_VOC_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOC_Enabled), 5, 0)));
            edtBUS_VOA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOA_Enabled), 5, 0)));
            edtBUS_AAA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAA_Enabled), 5, 0)));
            edtBUS_AEA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEA_Enabled), 5, 0)));
            edtBUS_VAH_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VAH_Enabled), 5, 0)));
            edtBUS_VHF_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VHF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VHF_Enabled), 5, 0)));
            edtBUS_VOH_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOH_Enabled), 5, 0)));
            edtBUS_AAH_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAH_Enabled), 5, 0)));
            edtBUS_AEH_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEH_Enabled), 5, 0)));
            edtBUS_VRA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRA_Enabled), 5, 0)));
            edtBUS_VRH_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRH_Enabled), 5, 0)));
            edtBUS_VUR_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUR_Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_0O0( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0O24( ) ;
            }
            else
            {
               CheckExtendedTable0O24( ) ;
               CloseExtendedTableCursors0O24( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0O0( )
      {
      }

      protected void E110O2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV15Context) ;
         AV27USUARIO = AV15Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27USUARIO", AV27USUARIO);
         tblTableprocesos_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTableprocesos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTableprocesos_Visible), 5, 0)));
         new isauthorized(context ).execute(  AV34Pgmname, out  AV21IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Pgmname", AV34Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21IsAuthorized", StringUtil.BoolToStr( AV21IsAuthorized));
         if ( ! AV21IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV34Pgmname)) ;
         }
         AV25TrnContext.FromXml(AV28WebSession.Get("TrnContext"), "");
         AV18Insert_BUS_COM = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_BUS_COM", AV18Insert_BUS_COM);
         AV17Insert_BUS_ARE = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Insert_BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Insert_BUS_ARE), 4, 0)));
         AV19Insert_BUS_SEC = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Insert_BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19Insert_BUS_SEC), 2, 0)));
         AV20Insert_BUS_TIP = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Insert_BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20Insert_BUS_TIP), 3, 0)));
         if ( ( StringUtil.StrCmp(AV25TrnContext.gxTpr_Transactionname, AV34Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV35GXV1 = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GXV1), 8, 0)));
            while ( AV35GXV1 <= AV25TrnContext.gxTpr_Attributes.Count )
            {
               AV26TrnContextAtt = ((SdtTransactionContext_Attribute)AV25TrnContext.gxTpr_Attributes.Item(AV35GXV1)) ;
               if ( StringUtil.StrCmp(AV26TrnContextAtt.gxTpr_Attributename, "BUS_COM") == 0 )
               {
                  AV18Insert_BUS_COM = AV26TrnContextAtt.gxTpr_Attributevalue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_BUS_COM", AV18Insert_BUS_COM);
               }
               else if ( StringUtil.StrCmp(AV26TrnContextAtt.gxTpr_Attributename, "BUS_ARE") == 0 )
               {
                  AV17Insert_BUS_ARE = (short)(NumberUtil.Val( AV26TrnContextAtt.gxTpr_Attributevalue, ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Insert_BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Insert_BUS_ARE), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV26TrnContextAtt.gxTpr_Attributename, "BUS_SEC") == 0 )
               {
                  AV19Insert_BUS_SEC = (short)(NumberUtil.Val( AV26TrnContextAtt.gxTpr_Attributevalue, ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Insert_BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19Insert_BUS_SEC), 2, 0)));
               }
               else if ( StringUtil.StrCmp(AV26TrnContextAtt.gxTpr_Attributename, "BUS_TIP") == 0 )
               {
                  AV20Insert_BUS_TIP = (short)(NumberUtil.Val( AV26TrnContextAtt.gxTpr_Attributevalue, ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Insert_BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20Insert_BUS_TIP), 3, 0)));
               }
               AV35GXV1 = (int)(AV35GXV1+1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GXV1), 8, 0)));
            }
         }
      }

      protected void E120O2( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            if ( A103BUS_IDT != 0 )
            {
               new ptbus030(context ).execute( ref  A8BUS_EMP, ref  A1BUS_RUB, ref  A3BUS_COD, ref  A4BUS_PAR, ref  A103BUS_IDT, ref  AV9BUS_IDT, ref  AV27USUARIO) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9BUS_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27USUARIO", AV27USUARIO);
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            AV9BUS_IDT = (int)(NumberUtil.Val( AV23SESION.Get("BUS_IDT"), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9BUS_IDT), 8, 0)));
            if ( A103BUS_IDT != AV9BUS_IDT )
            {
               new ptbus030(context ).execute( ref  A8BUS_EMP, ref  A1BUS_RUB, ref  A3BUS_COD, ref  A4BUS_PAR, ref  A103BUS_IDT, ref  AV9BUS_IDT, ref  AV27USUARIO) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9BUS_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27USUARIO", AV27USUARIO);
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV25TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwtbus000.aspx")  ;
         }
      }

      protected void ZM0O24( short GX_JID )
      {
         if ( ( GX_JID == 62 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z54BUS_DES = T000O3_A54BUS_DES[0] ;
               Z170BUS_FAL = T000O3_A170BUS_FAL[0] ;
               Z55BUS_FAD = T000O3_A55BUS_FAD[0] ;
               Z333BUS_NCO = T000O3_A333BUS_NCO[0] ;
               Z331BUS_COM = T000O3_A331BUS_COM[0] ;
               Z171BUS_ARE = T000O3_A171BUS_ARE[0] ;
               Z172BUS_SEC = T000O3_A172BUS_SEC[0] ;
               Z56BUS_TIP = T000O3_A56BUS_TIP[0] ;
               Z329BUS_VUA = T000O3_A329BUS_VUA[0] ;
               Z330BUS_VAO = T000O3_A330BUS_VAO[0] ;
               Z350BUS_CBD = T000O3_A350BUS_CBD[0] ;
               Z175BUS_ARD = T000O3_A175BUS_ARD[0] ;
               Z176BUS_SED = T000O3_A176BUS_SED[0] ;
               Z59BUS_TID = T000O3_A59BUS_TID[0] ;
               Z174BUS_FBA = T000O3_A174BUS_FBA[0] ;
               Z334BUS_MBA = T000O3_A334BUS_MBA[0] ;
               Z340BUS_FPR = T000O3_A340BUS_FPR[0] ;
               Z335BUS_VUT = T000O3_A335BUS_VUT[0] ;
               Z336BUS_COE = T000O3_A336BUS_COE[0] ;
               Z341BUS_VOC = T000O3_A341BUS_VOC[0] ;
               Z337BUS_VOA = T000O3_A337BUS_VOA[0] ;
               Z338BUS_AAA = T000O3_A338BUS_AAA[0] ;
               Z339BUS_AEA = T000O3_A339BUS_AEA[0] ;
               Z342BUS_VAH = T000O3_A342BUS_VAH[0] ;
               Z343BUS_VHF = T000O3_A343BUS_VHF[0] ;
               Z344BUS_VOH = T000O3_A344BUS_VOH[0] ;
               Z345BUS_AAH = T000O3_A345BUS_AAH[0] ;
               Z346BUS_AEH = T000O3_A346BUS_AEH[0] ;
               Z103BUS_IDT = T000O3_A103BUS_IDT[0] ;
            }
            else
            {
               Z54BUS_DES = A54BUS_DES ;
               Z170BUS_FAL = A170BUS_FAL ;
               Z55BUS_FAD = A55BUS_FAD ;
               Z333BUS_NCO = A333BUS_NCO ;
               Z331BUS_COM = A331BUS_COM ;
               Z171BUS_ARE = A171BUS_ARE ;
               Z172BUS_SEC = A172BUS_SEC ;
               Z56BUS_TIP = A56BUS_TIP ;
               Z329BUS_VUA = A329BUS_VUA ;
               Z330BUS_VAO = A330BUS_VAO ;
               Z350BUS_CBD = A350BUS_CBD ;
               Z175BUS_ARD = A175BUS_ARD ;
               Z176BUS_SED = A176BUS_SED ;
               Z59BUS_TID = A59BUS_TID ;
               Z174BUS_FBA = A174BUS_FBA ;
               Z334BUS_MBA = A334BUS_MBA ;
               Z340BUS_FPR = A340BUS_FPR ;
               Z335BUS_VUT = A335BUS_VUT ;
               Z336BUS_COE = A336BUS_COE ;
               Z341BUS_VOC = A341BUS_VOC ;
               Z337BUS_VOA = A337BUS_VOA ;
               Z338BUS_AAA = A338BUS_AAA ;
               Z339BUS_AEA = A339BUS_AEA ;
               Z342BUS_VAH = A342BUS_VAH ;
               Z343BUS_VHF = A343BUS_VHF ;
               Z344BUS_VOH = A344BUS_VOH ;
               Z345BUS_AAH = A345BUS_AAH ;
               Z346BUS_AEH = A346BUS_AEH ;
               Z103BUS_IDT = A103BUS_IDT ;
            }
         }
         if ( GX_JID == -62 )
         {
            Z8BUS_EMP = A8BUS_EMP ;
            Z3BUS_COD = A3BUS_COD ;
            Z4BUS_PAR = A4BUS_PAR ;
            Z54BUS_DES = A54BUS_DES ;
            Z170BUS_FAL = A170BUS_FAL ;
            Z55BUS_FAD = A55BUS_FAD ;
            Z333BUS_NCO = A333BUS_NCO ;
            Z331BUS_COM = A331BUS_COM ;
            Z171BUS_ARE = A171BUS_ARE ;
            Z172BUS_SEC = A172BUS_SEC ;
            Z56BUS_TIP = A56BUS_TIP ;
            Z329BUS_VUA = A329BUS_VUA ;
            Z330BUS_VAO = A330BUS_VAO ;
            Z350BUS_CBD = A350BUS_CBD ;
            Z175BUS_ARD = A175BUS_ARD ;
            Z176BUS_SED = A176BUS_SED ;
            Z59BUS_TID = A59BUS_TID ;
            Z174BUS_FBA = A174BUS_FBA ;
            Z334BUS_MBA = A334BUS_MBA ;
            Z340BUS_FPR = A340BUS_FPR ;
            Z335BUS_VUT = A335BUS_VUT ;
            Z336BUS_COE = A336BUS_COE ;
            Z341BUS_VOC = A341BUS_VOC ;
            Z337BUS_VOA = A337BUS_VOA ;
            Z338BUS_AAA = A338BUS_AAA ;
            Z339BUS_AEA = A339BUS_AEA ;
            Z342BUS_VAH = A342BUS_VAH ;
            Z343BUS_VHF = A343BUS_VHF ;
            Z344BUS_VOH = A344BUS_VOH ;
            Z345BUS_AAH = A345BUS_AAH ;
            Z346BUS_AEH = A346BUS_AEH ;
            Z103BUS_IDT = A103BUS_IDT ;
            Z1BUS_RUB = A1BUS_RUB ;
            Z61BUS_RUD = A61BUS_RUD ;
            Z178BUS_AMO = A178BUS_AMO ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBUS_FPR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FPR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FPR_Enabled), 5, 0)));
         edtBUS_VUT_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUT_Enabled), 5, 0)));
         edtBUS_COE_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COE_Enabled), 5, 0)));
         edtBUS_VOC_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOC_Enabled), 5, 0)));
         edtBUS_VOA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOA_Enabled), 5, 0)));
         edtBUS_AAA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAA_Enabled), 5, 0)));
         edtBUS_AEA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEA_Enabled), 5, 0)));
         edtBUS_VAH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VAH_Enabled), 5, 0)));
         edtBUS_VHF_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VHF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VHF_Enabled), 5, 0)));
         edtBUS_VOH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOH_Enabled), 5, 0)));
         edtBUS_AAH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAH_Enabled), 5, 0)));
         edtBUS_AEH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEH_Enabled), 5, 0)));
         edtBUS_VRA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRA_Enabled), 5, 0)));
         edtBUS_VRH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRH_Enabled), 5, 0)));
         edtBUS_VUR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUR_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0110.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_RUB"+"'), id:'"+"BUS_RUB"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_103_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"htbus030_1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_IDT"+"'), id:'"+"BUS_IDT"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         edtBUS_FPR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_FPR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FPR_Enabled), 5, 0)));
         edtBUS_VUT_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUT_Enabled), 5, 0)));
         edtBUS_COE_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COE_Enabled), 5, 0)));
         edtBUS_VOC_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOC_Enabled), 5, 0)));
         edtBUS_VOA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOA_Enabled), 5, 0)));
         edtBUS_AAA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAA_Enabled), 5, 0)));
         edtBUS_AEA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEA_Enabled), 5, 0)));
         edtBUS_VAH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VAH_Enabled), 5, 0)));
         edtBUS_VHF_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VHF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VHF_Enabled), 5, 0)));
         edtBUS_VOH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VOH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOH_Enabled), 5, 0)));
         edtBUS_AAH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AAH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAH_Enabled), 5, 0)));
         edtBUS_AEH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AEH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEH_Enabled), 5, 0)));
         edtBUS_VRA_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRA_Enabled), 5, 0)));
         edtBUS_VRH_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VRH_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRH_Enabled), 5, 0)));
         edtBUS_VUR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_VUR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUR_Enabled), 5, 0)));
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8BUS_EMP)) )
         {
            edtBUS_EMP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_EMP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_EMP_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_EMP_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_EMP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_EMP_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8BUS_EMP)) )
         {
            edtBUS_EMP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_EMP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_EMP_Enabled), 5, 0)));
         }
         if ( ! (0==AV11BUS_RUB) )
         {
            A1BUS_RUB = AV11BUS_RUB ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
         }
         if ( ! (0==AV11BUS_RUB) )
         {
            edtBUS_RUB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_RUB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_RUB_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_RUB_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_RUB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_RUB_Enabled), 5, 0)));
         }
         if ( ! (0==AV11BUS_RUB) )
         {
            edtBUS_RUB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_RUB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_RUB_Enabled), 5, 0)));
         }
         if ( ! (0==AV7BUS_COD) )
         {
            A3BUS_COD = AV7BUS_COD ;
            n3BUS_COD = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
         }
         if ( ! (0==AV7BUS_COD) )
         {
            edtBUS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COD_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV7BUS_COD) )
         {
            edtBUS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV10BUS_PAR) )
         {
            A4BUS_PAR = AV10BUS_PAR ;
            n4BUS_PAR = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
         }
         if ( ! (0==AV10BUS_PAR) )
         {
            edtBUS_PAR_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_PAR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_PAR_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_PAR_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_PAR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_PAR_Enabled), 5, 0)));
         }
         if ( ! (0==AV10BUS_PAR) )
         {
            edtBUS_PAR_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_PAR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_PAR_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18Insert_BUS_COM)) )
         {
            edtBUS_COM_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COM_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_COM_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_COM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COM_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_BUS_ARE) )
         {
            edtBUS_ARE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_ARE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_ARE_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_ARE_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_ARE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_ARE_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_BUS_SEC) )
         {
            edtBUS_SEC_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_SEC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_SEC_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_SEC_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_SEC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_SEC_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV20Insert_BUS_TIP) )
         {
            edtBUS_TIP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_TIP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_TIP_Enabled), 5, 0)));
         }
         else
         {
            edtBUS_TIP_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_TIP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_TIP_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV20Insert_BUS_TIP) )
         {
            A56BUS_TIP = AV20Insert_BUS_TIP ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_BUS_SEC) )
         {
            A172BUS_SEC = AV19Insert_BUS_SEC ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_BUS_ARE) )
         {
            A171BUS_ARE = AV17Insert_BUS_ARE ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18Insert_BUS_COM)) )
         {
            A331BUS_COM = AV18Insert_BUS_COM ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8BUS_EMP)) )
         {
            A8BUS_EMP = AV8BUS_EMP ;
            n8BUS_EMP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A8BUS_EMP)) && ( Gx_BScreen == 0 ) )
            {
               A8BUS_EMP = "M" ;
               n8BUS_EMP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A103BUS_IDT) && ( Gx_BScreen == 0 ) )
         {
            A103BUS_IDT = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV34Pgmname = "TBUS000" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Pgmname", AV34Pgmname);
            /* Using cursor T000O4 */
            pr_default.execute(2, new Object[] {n1BUS_RUB, A1BUS_RUB});
            A61BUS_RUD = T000O4_A61BUS_RUD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
            n61BUS_RUD = T000O4_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O4_A178BUS_AMO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
            n178BUS_AMO = T000O4_n178BUS_AMO[0] ;
            pr_default.close(2);
         }
      }

      protected void Load0O24( )
      {
         /* Using cursor T000O5 */
         pr_default.execute(3, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound24 = 1 ;
            A54BUS_DES = T000O5_A54BUS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            A170BUS_FAL = T000O5_A170BUS_FAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            A55BUS_FAD = T000O5_A55BUS_FAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            A333BUS_NCO = T000O5_A333BUS_NCO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            A331BUS_COM = T000O5_A331BUS_COM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
            A171BUS_ARE = T000O5_A171BUS_ARE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
            A172BUS_SEC = T000O5_A172BUS_SEC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
            A56BUS_TIP = T000O5_A56BUS_TIP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
            A61BUS_RUD = T000O5_A61BUS_RUD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
            n61BUS_RUD = T000O5_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O5_A178BUS_AMO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
            n178BUS_AMO = T000O5_n178BUS_AMO[0] ;
            A329BUS_VUA = T000O5_A329BUS_VUA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
            A330BUS_VAO = T000O5_A330BUS_VAO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
            A350BUS_CBD = T000O5_A350BUS_CBD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
            A175BUS_ARD = T000O5_A175BUS_ARD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
            A176BUS_SED = T000O5_A176BUS_SED[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
            A59BUS_TID = T000O5_A59BUS_TID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
            A174BUS_FBA = T000O5_A174BUS_FBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
            A334BUS_MBA = T000O5_A334BUS_MBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
            A340BUS_FPR = T000O5_A340BUS_FPR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
            A335BUS_VUT = T000O5_A335BUS_VUT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
            A336BUS_COE = T000O5_A336BUS_COE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
            A341BUS_VOC = T000O5_A341BUS_VOC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
            A337BUS_VOA = T000O5_A337BUS_VOA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
            A338BUS_AAA = T000O5_A338BUS_AAA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
            A339BUS_AEA = T000O5_A339BUS_AEA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
            A342BUS_VAH = T000O5_A342BUS_VAH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
            A343BUS_VHF = T000O5_A343BUS_VHF[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
            A344BUS_VOH = T000O5_A344BUS_VOH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
            A345BUS_AAH = T000O5_A345BUS_AAH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
            A346BUS_AEH = T000O5_A346BUS_AEH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
            A103BUS_IDT = T000O5_A103BUS_IDT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            ZM0O24( -62) ;
         }
         pr_default.close(3);
         OnLoadActions0O24( ) ;
      }

      protected void OnLoadActions0O24( )
      {
         AV34Pgmname = "TBUS000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Pgmname", AV34Pgmname);
         A349BUS_VUR = (short)(A329BUS_VUA-A335BUS_VUT) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
         A347BUS_VRA = (decimal)(A337BUS_VOA-A338BUS_AAA-A339BUS_AEA) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
         A348BUS_VRH = (decimal)(A344BUS_VOH-A345BUS_AAH-A346BUS_AEH) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
      }

      protected void CheckExtendedTable0O24( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV34Pgmname = "TBUS000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Pgmname", AV34Pgmname);
         if ( ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ( true /* After */ ) && ( ( ( NumberUtil.Val( AV23SESION.Get("nro_lectura"), ".") ) == Convert.ToDecimal( 0 )) ) ) )
         {
            new pbus021(context ).execute( out  A1BUS_RUB, out  A54BUS_DES, out  A170BUS_FAL, out  A55BUS_FAD, out  A333BUS_NCO, out  A331BUS_COM) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
         }
         /* Using cursor T000O4 */
         pr_default.execute(2, new Object[] {n1BUS_RUB, A1BUS_RUB});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'RUBRO BIENES DE USO'.", "ForeignKeyNotFound", 1, "BUS_RUB");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_RUB_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A61BUS_RUD = T000O4_A61BUS_RUD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
            n61BUS_RUD = T000O4_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O4_A178BUS_AMO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
            n178BUS_AMO = T000O4_n178BUS_AMO[0] ;
         }
         pr_default.close(2);
         if ( (0==A3BUS_COD) )
         {
            GX_msglist.addItem("El bien debe tener un código.", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            new ptbus000(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR, out  AV16error) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16error", StringUtil.Str( (decimal)(AV16error), 1, 0));
         }
         if ( ( AV16error == 1 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("Ya existe el bien que está intentando cargar.", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A54BUS_DES)) )
         {
            GX_msglist.addItem("El bien debe llevar una descripción.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A170BUS_FAL) || ( A170BUS_FAL >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE ALTA DEL BIEN fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( (DateTime.MinValue==A170BUS_FAL) )
         {
            GX_msglist.addItem("El bien debe llevar una fecha de alta.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A55BUS_FAD) || ( A55BUS_FAD >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE ADQUISICION DEL BIEN fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( (DateTime.MinValue==A55BUS_FAD) )
         {
            GX_msglist.addItem("El bien debe llevar una fecha de adquisición.", 1, "");
            AnyError = 1 ;
         }
         A349BUS_VUR = (short)(A329BUS_VUA-A335BUS_VUT) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
         if ( (Convert.ToDecimal(0)==A330BUS_VAO) )
         {
            GX_msglist.addItem("El bien debe tener un valor de origen.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A174BUS_FBA) || ( A174BUS_FBA >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE BAJA DEL BIEN fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! (DateTime.MinValue==A174BUS_FBA) && ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A103BUS_IDT, out  AV32error_2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32error_2", StringUtil.Str( (decimal)(AV32error_2), 1, 0));
         }
         if ( ( AV32error_2 == 1 ) && ! (DateTime.MinValue==A174BUS_FBA) && ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem("No puede dar de baja este bien porque no está dado de baja en trazabilidad de bienes de uso.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_2(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR,  A103BUS_IDT, out  AV31error_t, out  AV30mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31error_t", StringUtil.Str( (decimal)(AV31error_t), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30mensaje", AV30mensaje);
         }
         if ( ( A103BUS_IDT != 0 ) && ( AV31error_t == 1 ) && true /* After */ )
         {
            GX_msglist.addItem(AV30mensaje, 1, "");
            AnyError = 1 ;
         }
         A347BUS_VRA = (decimal)(A337BUS_VOA-A338BUS_AAA-A339BUS_AEA) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
         A348BUS_VRH = (decimal)(A344BUS_VOH-A345BUS_AAH-A346BUS_AEH) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
      }

      protected void CloseExtendedTableCursors0O24( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_63( short A1BUS_RUB )
      {
         /* Using cursor T000O6 */
         pr_default.execute(4, new Object[] {n1BUS_RUB, A1BUS_RUB});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'RUBRO BIENES DE USO'.", "ForeignKeyNotFound", 1, "BUS_RUB");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_RUB_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A61BUS_RUD = T000O6_A61BUS_RUD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
            n61BUS_RUD = T000O6_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O6_A178BUS_AMO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
            n178BUS_AMO = T000O6_n178BUS_AMO[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A61BUS_RUD))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A178BUS_AMO))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0O24( )
      {
         /* Using cursor T000O7 */
         pr_default.execute(5, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound24 = 1 ;
         }
         else
         {
            RcdFound24 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000O3 */
         pr_default.execute(1, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O24( 62) ;
            RcdFound24 = 1 ;
            A8BUS_EMP = T000O3_A8BUS_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            n8BUS_EMP = T000O3_n8BUS_EMP[0] ;
            A3BUS_COD = T000O3_A3BUS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            n3BUS_COD = T000O3_n3BUS_COD[0] ;
            A4BUS_PAR = T000O3_A4BUS_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            n4BUS_PAR = T000O3_n4BUS_PAR[0] ;
            A54BUS_DES = T000O3_A54BUS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            A170BUS_FAL = T000O3_A170BUS_FAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            A55BUS_FAD = T000O3_A55BUS_FAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            A333BUS_NCO = T000O3_A333BUS_NCO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            A331BUS_COM = T000O3_A331BUS_COM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
            A171BUS_ARE = T000O3_A171BUS_ARE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
            A172BUS_SEC = T000O3_A172BUS_SEC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
            A56BUS_TIP = T000O3_A56BUS_TIP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
            A329BUS_VUA = T000O3_A329BUS_VUA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
            A330BUS_VAO = T000O3_A330BUS_VAO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
            A350BUS_CBD = T000O3_A350BUS_CBD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
            A175BUS_ARD = T000O3_A175BUS_ARD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
            A176BUS_SED = T000O3_A176BUS_SED[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
            A59BUS_TID = T000O3_A59BUS_TID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
            A174BUS_FBA = T000O3_A174BUS_FBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
            A334BUS_MBA = T000O3_A334BUS_MBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
            A340BUS_FPR = T000O3_A340BUS_FPR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
            A335BUS_VUT = T000O3_A335BUS_VUT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
            A336BUS_COE = T000O3_A336BUS_COE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
            A341BUS_VOC = T000O3_A341BUS_VOC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
            A337BUS_VOA = T000O3_A337BUS_VOA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
            A338BUS_AAA = T000O3_A338BUS_AAA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
            A339BUS_AEA = T000O3_A339BUS_AEA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
            A342BUS_VAH = T000O3_A342BUS_VAH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
            A343BUS_VHF = T000O3_A343BUS_VHF[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
            A344BUS_VOH = T000O3_A344BUS_VOH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
            A345BUS_AAH = T000O3_A345BUS_AAH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
            A346BUS_AEH = T000O3_A346BUS_AEH[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
            A103BUS_IDT = T000O3_A103BUS_IDT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            A1BUS_RUB = T000O3_A1BUS_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            n1BUS_RUB = T000O3_n1BUS_RUB[0] ;
            Z8BUS_EMP = A8BUS_EMP ;
            Z1BUS_RUB = A1BUS_RUB ;
            Z3BUS_COD = A3BUS_COD ;
            Z4BUS_PAR = A4BUS_PAR ;
            sMode24 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0O24( ) ;
            Gx_mode = sMode24 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound24 = 0 ;
            InitializeNonKey0O24( ) ;
            sMode24 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode24 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O24( ) ;
         if ( RcdFound24 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound24 = 0 ;
         /* Using cursor T000O8 */
         pr_default.execute(6, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) < 0 ) || ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A1BUS_RUB[0] < A1BUS_RUB ) || ( T000O8_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A3BUS_COD[0] < A3BUS_COD ) || ( T000O8_A3BUS_COD[0] == A3BUS_COD ) && ( T000O8_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A4BUS_PAR[0] < A4BUS_PAR ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) > 0 ) || ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A1BUS_RUB[0] > A1BUS_RUB ) || ( T000O8_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A3BUS_COD[0] > A3BUS_COD ) || ( T000O8_A3BUS_COD[0] == A3BUS_COD ) && ( T000O8_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O8_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O8_A4BUS_PAR[0] > A4BUS_PAR ) ) )
            {
               A8BUS_EMP = T000O8_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               n8BUS_EMP = T000O8_n8BUS_EMP[0] ;
               A1BUS_RUB = T000O8_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               n1BUS_RUB = T000O8_n1BUS_RUB[0] ;
               A3BUS_COD = T000O8_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               n3BUS_COD = T000O8_n3BUS_COD[0] ;
               A4BUS_PAR = T000O8_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               n4BUS_PAR = T000O8_n4BUS_PAR[0] ;
               RcdFound24 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound24 = 0 ;
         /* Using cursor T000O9 */
         pr_default.execute(7, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) > 0 ) || ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A1BUS_RUB[0] > A1BUS_RUB ) || ( T000O9_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A3BUS_COD[0] > A3BUS_COD ) || ( T000O9_A3BUS_COD[0] == A3BUS_COD ) && ( T000O9_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A4BUS_PAR[0] > A4BUS_PAR ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) < 0 ) || ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A1BUS_RUB[0] < A1BUS_RUB ) || ( T000O9_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A3BUS_COD[0] < A3BUS_COD ) || ( T000O9_A3BUS_COD[0] == A3BUS_COD ) && ( T000O9_A1BUS_RUB[0] == A1BUS_RUB ) && ( StringUtil.StrCmp(T000O9_A8BUS_EMP[0], A8BUS_EMP) == 0 ) && ( T000O9_A4BUS_PAR[0] < A4BUS_PAR ) ) )
            {
               A8BUS_EMP = T000O9_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               n8BUS_EMP = T000O9_n8BUS_EMP[0] ;
               A1BUS_RUB = T000O9_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               n1BUS_RUB = T000O9_n1BUS_RUB[0] ;
               A3BUS_COD = T000O9_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               n3BUS_COD = T000O9_n3BUS_COD[0] ;
               A4BUS_PAR = T000O9_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               n4BUS_PAR = T000O9_n4BUS_PAR[0] ;
               RcdFound24 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0O24( ) ;
         if ( RcdFound24 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "BUS_EMP");
               AnyError = 1 ;
               GX_FocusControl = edtBUS_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A8BUS_EMP, Z8BUS_EMP) != 0 ) || ( A1BUS_RUB != Z1BUS_RUB ) || ( A3BUS_COD != Z3BUS_COD ) || ( A4BUS_PAR != Z4BUS_PAR ) )
            {
               A8BUS_EMP = Z8BUS_EMP ;
               n8BUS_EMP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               A1BUS_RUB = Z1BUS_RUB ;
               n1BUS_RUB = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               A3BUS_COD = Z3BUS_COD ;
               n3BUS_COD = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               A4BUS_PAR = Z4BUS_PAR ;
               n4BUS_PAR = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "BUS_EMP");
               AnyError = 1 ;
               GX_FocusControl = edtBUS_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtBUS_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0O24( ) ;
               GX_FocusControl = edtBUS_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A8BUS_EMP, Z8BUS_EMP) != 0 ) || ( A1BUS_RUB != Z1BUS_RUB ) || ( A3BUS_COD != Z3BUS_COD ) || ( A4BUS_PAR != Z4BUS_PAR ) )
            {
               /* Insert record */
               Insert0O24( ) ;
               GX_FocusControl = edtBUS_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "BUS_EMP");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_EMP_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0O24( ) ;
                  GX_FocusControl = edtBUS_EMP_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A8BUS_EMP, Z8BUS_EMP) != 0 ) || ( A1BUS_RUB != Z1BUS_RUB ) || ( A3BUS_COD != Z3BUS_COD ) || ( A4BUS_PAR != Z4BUS_PAR ) )
         {
            A8BUS_EMP = Z8BUS_EMP ;
            n8BUS_EMP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            A1BUS_RUB = Z1BUS_RUB ;
            n1BUS_RUB = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A3BUS_COD = Z3BUS_COD ;
            n3BUS_COD = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            A4BUS_PAR = Z4BUS_PAR ;
            n4BUS_PAR = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "BUS_EMP");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_EMP_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBUS_EMP_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O10 */
            pr_default.execute(8, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BUS000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z54BUS_DES, T000O10_A54BUS_DES[0]) != 0 ) || ( Z170BUS_FAL != T000O10_A170BUS_FAL[0] ) || ( Z55BUS_FAD != T000O10_A55BUS_FAD[0] ) || ( StringUtil.StrCmp(Z333BUS_NCO, T000O10_A333BUS_NCO[0]) != 0 ) || ( StringUtil.StrCmp(Z331BUS_COM, T000O10_A331BUS_COM[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z171BUS_ARE != T000O10_A171BUS_ARE[0] ) || ( Z172BUS_SEC != T000O10_A172BUS_SEC[0] ) || ( Z56BUS_TIP != T000O10_A56BUS_TIP[0] ) || ( Z329BUS_VUA != T000O10_A329BUS_VUA[0] ) || ( Z330BUS_VAO != T000O10_A330BUS_VAO[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z350BUS_CBD, T000O10_A350BUS_CBD[0]) != 0 ) || ( StringUtil.StrCmp(Z175BUS_ARD, T000O10_A175BUS_ARD[0]) != 0 ) || ( StringUtil.StrCmp(Z176BUS_SED, T000O10_A176BUS_SED[0]) != 0 ) || ( StringUtil.StrCmp(Z59BUS_TID, T000O10_A59BUS_TID[0]) != 0 ) || ( Z174BUS_FBA != T000O10_A174BUS_FBA[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z334BUS_MBA, T000O10_A334BUS_MBA[0]) != 0 ) || ( Z340BUS_FPR != T000O10_A340BUS_FPR[0] ) || ( Z335BUS_VUT != T000O10_A335BUS_VUT[0] ) || ( Z336BUS_COE != T000O10_A336BUS_COE[0] ) || ( Z341BUS_VOC != T000O10_A341BUS_VOC[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z337BUS_VOA != T000O10_A337BUS_VOA[0] ) || ( Z338BUS_AAA != T000O10_A338BUS_AAA[0] ) || ( Z339BUS_AEA != T000O10_A339BUS_AEA[0] ) || ( Z342BUS_VAH != T000O10_A342BUS_VAH[0] ) || ( Z343BUS_VHF != T000O10_A343BUS_VHF[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z344BUS_VOH != T000O10_A344BUS_VOH[0] ) || ( Z345BUS_AAH != T000O10_A345BUS_AAH[0] ) || ( Z346BUS_AEH != T000O10_A346BUS_AEH[0] ) || ( Z103BUS_IDT != T000O10_A103BUS_IDT[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BUS000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O24( 0) ;
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O11 */
                     pr_default.execute(9, new Object[] {n8BUS_EMP, A8BUS_EMP, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR, A54BUS_DES, A170BUS_FAL, A55BUS_FAD, A333BUS_NCO, A331BUS_COM, A171BUS_ARE, A172BUS_SEC, A56BUS_TIP, A329BUS_VUA, A330BUS_VAO, A350BUS_CBD, A175BUS_ARD, A176BUS_SED, A59BUS_TID, A174BUS_FBA, A334BUS_MBA, A340BUS_FPR, A335BUS_VUT, A336BUS_COE, A341BUS_VOC, A337BUS_VOA, A338BUS_AAA, A339BUS_AEA, A342BUS_VAH, A343BUS_VHF, A344BUS_VOH, A345BUS_AAH, A346BUS_AEH, A103BUS_IDT, n1BUS_RUB, A1BUS_RUB});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0O0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load0O24( ) ;
            }
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void Update0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O12 */
                     pr_default.execute(10, new Object[] {A54BUS_DES, A170BUS_FAL, A55BUS_FAD, A333BUS_NCO, A331BUS_COM, A171BUS_ARE, A172BUS_SEC, A56BUS_TIP, A329BUS_VUA, A330BUS_VAO, A350BUS_CBD, A175BUS_ARD, A176BUS_SED, A59BUS_TID, A174BUS_FBA, A334BUS_MBA, A340BUS_FPR, A335BUS_VUT, A336BUS_COE, A341BUS_VOC, A337BUS_VOA, A338BUS_AAA, A339BUS_AEA, A342BUS_VAH, A343BUS_VHF, A344BUS_VOH, A345BUS_AAH, A346BUS_AEH, A103BUS_IDT, n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BUS000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0O24( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void DeferredUpdate0O24( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O24( ) ;
            AfterConfirm0O24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000O13 */
                  pr_default.execute(11, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode24 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0O24( ) ;
         Gx_mode = sMode24 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0O24( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV34Pgmname = "TBUS000" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Pgmname", AV34Pgmname);
            /* Using cursor T000O14 */
            pr_default.execute(12, new Object[] {n1BUS_RUB, A1BUS_RUB});
            A61BUS_RUD = T000O14_A61BUS_RUD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
            n61BUS_RUD = T000O14_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O14_A178BUS_AMO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
            n178BUS_AMO = T000O14_n178BUS_AMO[0] ;
            pr_default.close(12);
            A349BUS_VUR = (short)(A329BUS_VUA-A335BUS_VUT) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
            A347BUS_VRA = (decimal)(A337BUS_VOA-A338BUS_AAA-A339BUS_AEA) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
            A348BUS_VRH = (decimal)(A344BUS_VOH-A345BUS_AAH-A346BUS_AEH) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000O15 */
            pr_default.execute(13, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Bienes de Uso (Trazabilidad)"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("TBUS000");
            if ( AnyError == 0 )
            {
               ConfirmValues0O0( ) ;
            }
            /* After transaction rules */
            new pbus020(context ).execute(  A1BUS_RUB,  A54BUS_DES,  A170BUS_FAL,  A55BUS_FAD,  A333BUS_NCO,  A331BUS_COM) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.RollbackDataStores("TBUS000");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0O24( )
      {
         /* Using cursor T000O16 */
         pr_default.execute(14);
         RcdFound24 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound24 = 1 ;
            A8BUS_EMP = T000O16_A8BUS_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            n8BUS_EMP = T000O16_n8BUS_EMP[0] ;
            A1BUS_RUB = T000O16_A1BUS_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            n1BUS_RUB = T000O16_n1BUS_RUB[0] ;
            A3BUS_COD = T000O16_A3BUS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            n3BUS_COD = T000O16_n3BUS_COD[0] ;
            A4BUS_PAR = T000O16_A4BUS_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            n4BUS_PAR = T000O16_n4BUS_PAR[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O24( )
      {
         pr_default.readNext(14);
         RcdFound24 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound24 = 1 ;
            A8BUS_EMP = T000O16_A8BUS_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            n8BUS_EMP = T000O16_n8BUS_EMP[0] ;
            A1BUS_RUB = T000O16_A1BUS_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            n1BUS_RUB = T000O16_n1BUS_RUB[0] ;
            A3BUS_COD = T000O16_A3BUS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            n3BUS_COD = T000O16_n3BUS_COD[0] ;
            A4BUS_PAR = T000O16_A4BUS_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            n4BUS_PAR = T000O16_n4BUS_PAR[0] ;
         }
      }

      protected void ScanEnd0O24( )
      {
      }

      protected void AfterConfirm0O24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O24( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0O0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8BUS_EMP)) + "," + UrlEncode("" +AV11BUS_RUB) + "," + UrlEncode("" +AV7BUS_COD) + "," + UrlEncode("" +AV10BUS_PAR)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z8BUS_EMP", StringUtil.RTrim( Z8BUS_EMP));
         GxWebStd.gx_hidden_field( context, "Z1BUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1BUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3BUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3BUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z4BUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4BUS_PAR), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z54BUS_DES", StringUtil.RTrim( Z54BUS_DES));
         GxWebStd.gx_hidden_field( context, "Z170BUS_FAL", context.localUtil.DToC( Z170BUS_FAL, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z55BUS_FAD", context.localUtil.DToC( Z55BUS_FAD, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z333BUS_NCO", StringUtil.RTrim( Z333BUS_NCO));
         GxWebStd.gx_hidden_field( context, "Z331BUS_COM", StringUtil.RTrim( Z331BUS_COM));
         GxWebStd.gx_hidden_field( context, "Z171BUS_ARE", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z171BUS_ARE), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z172BUS_SEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z172BUS_SEC), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z56BUS_TIP", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z56BUS_TIP), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z329BUS_VUA", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z329BUS_VUA), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z330BUS_VAO", StringUtil.LTrim( StringUtil.NToC( Z330BUS_VAO, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z350BUS_CBD", StringUtil.RTrim( Z350BUS_CBD));
         GxWebStd.gx_hidden_field( context, "Z175BUS_ARD", StringUtil.RTrim( Z175BUS_ARD));
         GxWebStd.gx_hidden_field( context, "Z176BUS_SED", StringUtil.RTrim( Z176BUS_SED));
         GxWebStd.gx_hidden_field( context, "Z59BUS_TID", StringUtil.RTrim( Z59BUS_TID));
         GxWebStd.gx_hidden_field( context, "Z174BUS_FBA", context.localUtil.DToC( Z174BUS_FBA, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z334BUS_MBA", StringUtil.RTrim( Z334BUS_MBA));
         GxWebStd.gx_hidden_field( context, "Z340BUS_FPR", context.localUtil.DToC( Z340BUS_FPR, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z335BUS_VUT", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z335BUS_VUT), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z336BUS_COE", StringUtil.LTrim( StringUtil.NToC( Z336BUS_COE, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z341BUS_VOC", StringUtil.LTrim( StringUtil.NToC( Z341BUS_VOC, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z337BUS_VOA", StringUtil.LTrim( StringUtil.NToC( Z337BUS_VOA, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z338BUS_AAA", StringUtil.LTrim( StringUtil.NToC( Z338BUS_AAA, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z339BUS_AEA", StringUtil.LTrim( StringUtil.NToC( Z339BUS_AEA, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z342BUS_VAH", StringUtil.LTrim( StringUtil.NToC( Z342BUS_VAH, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z343BUS_VHF", context.localUtil.DToC( Z343BUS_VHF, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z344BUS_VOH", StringUtil.LTrim( StringUtil.NToC( Z344BUS_VOH, 18, 7, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z345BUS_AAH", StringUtil.LTrim( StringUtil.NToC( Z345BUS_AAH, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z346BUS_AEH", StringUtil.LTrim( StringUtil.NToC( Z346BUS_AEH, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z103BUS_IDT", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z103BUS_IDT), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "N331BUS_COM", StringUtil.RTrim( A331BUS_COM));
         GxWebStd.gx_hidden_field( context, "N171BUS_ARE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A171BUS_ARE), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N172BUS_SEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BUS_SEC), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N56BUS_TIP", StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_EMP", StringUtil.RTrim( AV8BUS_EMP));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11BUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BUS_PAR), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_BUS_COM", StringUtil.RTrim( AV18Insert_BUS_COM));
         GxWebStd.gx_hidden_field( context, "vINSERT_BUS_ARE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Insert_BUS_ARE), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_BUS_SEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19Insert_BUS_SEC), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_BUS_TIP", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20Insert_BUS_TIP), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vERROR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16error), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vERROR_T", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31error_t), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMENSAJE", StringUtil.RTrim( AV30mensaje));
         GxWebStd.gx_hidden_field( context, "vERROR_2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32error_2), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "BUS_RUD", StringUtil.RTrim( A61BUS_RUD));
         GxWebStd.gx_hidden_field( context, "BUS_AMO", StringUtil.RTrim( A178BUS_AMO));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV34Pgmname));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TBUS000" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. DE BIENES DE USO" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8BUS_EMP)) + "," + UrlEncode("" +AV11BUS_RUB) + "," + UrlEncode("" +AV7BUS_COD) + "," + UrlEncode("" +AV10BUS_PAR) ;
      }

      protected void InitializeNonKey0O24( )
      {
         A54BUS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
         A170BUS_FAL = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
         A55BUS_FAD = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
         A333BUS_NCO = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
         A331BUS_COM = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
         A171BUS_ARE = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
         A172BUS_SEC = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
         A56BUS_TIP = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
         AV16error = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16error", StringUtil.Str( (decimal)(AV16error), 1, 0));
         AV31error_t = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31error_t", StringUtil.Str( (decimal)(AV31error_t), 1, 0));
         AV30mensaje = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30mensaje", AV30mensaje);
         AV32error_2 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32error_2", StringUtil.Str( (decimal)(AV32error_2), 1, 0));
         A348BUS_VRH = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
         A347BUS_VRA = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
         A349BUS_VUR = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
         A61BUS_RUD = "" ;
         n61BUS_RUD = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
         A178BUS_AMO = "" ;
         n178BUS_AMO = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
         A329BUS_VUA = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
         A330BUS_VAO = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
         A350BUS_CBD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
         A175BUS_ARD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
         A176BUS_SED = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
         A59BUS_TID = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
         A174BUS_FBA = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
         A334BUS_MBA = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
         A340BUS_FPR = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
         A335BUS_VUT = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
         A336BUS_COE = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
         A341BUS_VOC = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
         A337BUS_VOA = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
         A338BUS_AAA = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
         A339BUS_AEA = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
         A342BUS_VAH = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
         A343BUS_VHF = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
         A344BUS_VOH = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
         A345BUS_AAH = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
         A346BUS_AEH = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
         A103BUS_IDT = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
      }

      protected void InitAll0O24( )
      {
         A8BUS_EMP = "M" ;
         n8BUS_EMP = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
         A1BUS_RUB = 0 ;
         n1BUS_RUB = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
         A3BUS_COD = 0 ;
         n3BUS_COD = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
         A4BUS_PAR = 0 ;
         n4BUS_PAR = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
         InitializeNonKey0O24( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A103BUS_IDT = i103BUS_IDT ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1175476");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gxdec.js", "?42940");
         context.AddJavascriptSource("tbus000.js", "?1175477");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockbus_emp_Internalname = "TEXTBLOCKBUS_EMP" ;
         edtBUS_EMP_Internalname = "BUS_EMP" ;
         lblTextblockbus_rub_Internalname = "TEXTBLOCKBUS_RUB" ;
         edtBUS_RUB_Internalname = "BUS_RUB" ;
         lblTextblockbus_cod_Internalname = "TEXTBLOCKBUS_COD" ;
         edtBUS_COD_Internalname = "BUS_COD" ;
         edtBUS_PAR_Internalname = "BUS_PAR" ;
         lblTextblockbus_des_Internalname = "TEXTBLOCKBUS_DES" ;
         edtBUS_DES_Internalname = "BUS_DES" ;
         lblTextblockbus_fal_Internalname = "TEXTBLOCKBUS_FAL" ;
         edtBUS_FAL_Internalname = "BUS_FAL" ;
         lblTextblockbus_fad_Internalname = "TEXTBLOCKBUS_FAD" ;
         edtBUS_FAD_Internalname = "BUS_FAD" ;
         lblTextblockbus_vua_Internalname = "TEXTBLOCKBUS_VUA" ;
         edtBUS_VUA_Internalname = "BUS_VUA" ;
         lblTextblockbus_vao_Internalname = "TEXTBLOCKBUS_VAO" ;
         edtBUS_VAO_Internalname = "BUS_VAO" ;
         lblTextblockbus_com_Internalname = "TEXTBLOCKBUS_COM" ;
         edtBUS_COM_Internalname = "BUS_COM" ;
         edtBUS_CBD_Internalname = "BUS_CBD" ;
         lblTextblockbus_nco_Internalname = "TEXTBLOCKBUS_NCO" ;
         edtBUS_NCO_Internalname = "BUS_NCO" ;
         lblTextblockbus_sec_Internalname = "TEXTBLOCKBUS_SEC" ;
         edtBUS_SEC_Internalname = "BUS_SEC" ;
         edtBUS_SED_Internalname = "BUS_SED" ;
         lblTextblockbus_are_Internalname = "TEXTBLOCKBUS_ARE" ;
         edtBUS_ARE_Internalname = "BUS_ARE" ;
         edtBUS_ARD_Internalname = "BUS_ARD" ;
         lblTextblockbus_tip_Internalname = "TEXTBLOCKBUS_TIP" ;
         edtBUS_TIP_Internalname = "BUS_TIP" ;
         edtBUS_TID_Internalname = "BUS_TID" ;
         lblTextblockbus_fba_Internalname = "TEXTBLOCKBUS_FBA" ;
         edtBUS_FBA_Internalname = "BUS_FBA" ;
         lblTextblockbus_mba_Internalname = "TEXTBLOCKBUS_MBA" ;
         edtBUS_MBA_Internalname = "BUS_MBA" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtBUS_IDT_Internalname = "BUS_IDT" ;
         tblTable2_Internalname = "TABLE2" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblockbus_fpr_Internalname = "TEXTBLOCKBUS_FPR" ;
         edtBUS_FPR_Internalname = "BUS_FPR" ;
         lblTextblockbus_vut_Internalname = "TEXTBLOCKBUS_VUT" ;
         edtBUS_VUT_Internalname = "BUS_VUT" ;
         lblTextblockbus_coe_Internalname = "TEXTBLOCKBUS_COE" ;
         edtBUS_COE_Internalname = "BUS_COE" ;
         lblTextblockbus_voc_Internalname = "TEXTBLOCKBUS_VOC" ;
         edtBUS_VOC_Internalname = "BUS_VOC" ;
         lblTextblockbus_voa_Internalname = "TEXTBLOCKBUS_VOA" ;
         edtBUS_VOA_Internalname = "BUS_VOA" ;
         lblTextblockbus_aaa_Internalname = "TEXTBLOCKBUS_AAA" ;
         edtBUS_AAA_Internalname = "BUS_AAA" ;
         lblTextblockbus_aea_Internalname = "TEXTBLOCKBUS_AEA" ;
         edtBUS_AEA_Internalname = "BUS_AEA" ;
         lblTextblockbus_aea2_Internalname = "TEXTBLOCKBUS_AEA2" ;
         edtBUS_VAH_Internalname = "BUS_VAH" ;
         lblTextblockbus_aea3_Internalname = "TEXTBLOCKBUS_AEA3" ;
         edtBUS_VHF_Internalname = "BUS_VHF" ;
         lblTextblockbus_voh_Internalname = "TEXTBLOCKBUS_VOH" ;
         edtBUS_VOH_Internalname = "BUS_VOH" ;
         lblTextblockbus_aah_Internalname = "TEXTBLOCKBUS_AAH" ;
         edtBUS_AAH_Internalname = "BUS_AAH" ;
         lblTextblockbus_aeh_Internalname = "TEXTBLOCKBUS_AEH" ;
         edtBUS_AEH_Internalname = "BUS_AEH" ;
         lblTextblockbus_vra_Internalname = "TEXTBLOCKBUS_VRA" ;
         edtBUS_VRA_Internalname = "BUS_VRA" ;
         lblTextblockbus_vrh_Internalname = "TEXTBLOCKBUS_VRH" ;
         edtBUS_VRH_Internalname = "BUS_VRH" ;
         lblTextblockbus_vur_Internalname = "TEXTBLOCKBUS_VUR" ;
         edtBUS_VUR_Internalname = "BUS_VUR" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTableprocesos_Internalname = "TABLEPROCESOS" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_1_Internalname = "PROMPT_1" ;
         imgprompt_103_Internalname = "PROMPT_103" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. DE BIENES DE USO" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         imgprompt_103_Visible = 1 ;
         imgprompt_103_Link = "" ;
         edtBUS_IDT_Jsonclick = "" ;
         edtBUS_IDT_Enabled = 1 ;
         edtBUS_MBA_Jsonclick = "" ;
         edtBUS_MBA_Enabled = 1 ;
         edtBUS_FBA_Jsonclick = "" ;
         edtBUS_FBA_Enabled = 1 ;
         edtBUS_TID_Jsonclick = "" ;
         edtBUS_TID_Enabled = 1 ;
         edtBUS_TIP_Jsonclick = "" ;
         edtBUS_TIP_Enabled = 1 ;
         edtBUS_ARD_Jsonclick = "" ;
         edtBUS_ARD_Enabled = 1 ;
         edtBUS_ARE_Jsonclick = "" ;
         edtBUS_ARE_Enabled = 1 ;
         edtBUS_SED_Jsonclick = "" ;
         edtBUS_SED_Enabled = 1 ;
         edtBUS_SEC_Jsonclick = "" ;
         edtBUS_SEC_Enabled = 1 ;
         edtBUS_NCO_Jsonclick = "" ;
         edtBUS_NCO_Enabled = 1 ;
         edtBUS_CBD_Jsonclick = "" ;
         edtBUS_CBD_Enabled = 1 ;
         edtBUS_COM_Jsonclick = "" ;
         edtBUS_COM_Enabled = 1 ;
         edtBUS_VAO_Jsonclick = "" ;
         edtBUS_VAO_Enabled = 1 ;
         edtBUS_VUA_Jsonclick = "" ;
         edtBUS_VUA_Enabled = 1 ;
         edtBUS_FAD_Jsonclick = "" ;
         edtBUS_FAD_Enabled = 1 ;
         edtBUS_FAL_Jsonclick = "" ;
         edtBUS_FAL_Enabled = 1 ;
         edtBUS_DES_Jsonclick = "" ;
         edtBUS_DES_Enabled = 1 ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_PAR_Enabled = 1 ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_COD_Enabled = 1 ;
         imgprompt_1_Visible = 1 ;
         imgprompt_1_Link = "" ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_RUB_Enabled = 1 ;
         edtBUS_EMP_Jsonclick = "" ;
         edtBUS_EMP_Enabled = 1 ;
         edtBUS_VUR_Jsonclick = "" ;
         edtBUS_VUR_Enabled = 0 ;
         edtBUS_VRH_Jsonclick = "" ;
         edtBUS_VRH_Enabled = 0 ;
         edtBUS_VRA_Jsonclick = "" ;
         edtBUS_VRA_Enabled = 0 ;
         edtBUS_AEH_Jsonclick = "" ;
         edtBUS_AEH_Enabled = 0 ;
         edtBUS_AAH_Jsonclick = "" ;
         edtBUS_AAH_Enabled = 0 ;
         edtBUS_VOH_Jsonclick = "" ;
         edtBUS_VOH_Enabled = 0 ;
         edtBUS_VHF_Jsonclick = "" ;
         edtBUS_VHF_Enabled = 0 ;
         edtBUS_VAH_Jsonclick = "" ;
         edtBUS_VAH_Enabled = 0 ;
         edtBUS_AEA_Jsonclick = "" ;
         edtBUS_AEA_Enabled = 0 ;
         edtBUS_AAA_Jsonclick = "" ;
         edtBUS_AAA_Enabled = 0 ;
         edtBUS_VOA_Jsonclick = "" ;
         edtBUS_VOA_Enabled = 0 ;
         edtBUS_VOC_Jsonclick = "" ;
         edtBUS_VOC_Enabled = 0 ;
         edtBUS_COE_Jsonclick = "" ;
         edtBUS_COE_Enabled = 0 ;
         edtBUS_VUT_Jsonclick = "" ;
         edtBUS_VUT_Enabled = 0 ;
         edtBUS_FPR_Jsonclick = "" ;
         edtBUS_FPR_Enabled = 0 ;
         tblTableprocesos_Visible = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void XC_41_0O24( String Gx_mode ,
                                 String A8BUS_EMP )
      {
         if ( ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ( true /* After */ ) && ( ( ( NumberUtil.Val( AV23SESION.Get("nro_lectura"), ".") ) == Convert.ToDecimal( 0 )) ) ) )
         {
            new pbus021(context ).execute( out  A1BUS_RUB, out  A54BUS_DES, out  A170BUS_FAL, out  A55BUS_FAD, out  A333BUS_NCO, out  A331BUS_COM) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A54BUS_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A170BUS_FAL, "99/99/9999"))+"\""+","+"\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A55BUS_FAD, "99/99/9999"))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A333BUS_NCO))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A331BUS_COM))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_55_0O24( String A8BUS_EMP ,
                                 short A1BUS_RUB ,
                                 short A3BUS_COD ,
                                 short A4BUS_PAR ,
                                 String Gx_mode )
      {
         if ( true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            new ptbus000(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR, out  AV16error) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16error", StringUtil.Str( (decimal)(AV16error), 1, 0));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16error), 1, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_57_0O24( short A1BUS_RUB ,
                                 String A54BUS_DES ,
                                 DateTime A170BUS_FAL ,
                                 DateTime A55BUS_FAD ,
                                 String A333BUS_NCO ,
                                 String A331BUS_COM )
      {
         new pbus020(context ).execute(  A1BUS_RUB,  A54BUS_DES,  A170BUS_FAL,  A55BUS_FAD,  A333BUS_NCO,  A331BUS_COM) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_58_0O24( String A8BUS_EMP ,
                                 short A1BUS_RUB ,
                                 short A3BUS_COD ,
                                 short A4BUS_PAR ,
                                 int A103BUS_IDT )
      {
         if ( ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_2(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR,  A103BUS_IDT, out  AV31error_t, out  AV30mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31error_t", StringUtil.Str( (decimal)(AV31error_t), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30mensaje", AV30mensaje);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31error_t), 1, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV30mensaje))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_60_0O24( int A103BUS_IDT ,
                                 DateTime A174BUS_FBA )
      {
         if ( ! (DateTime.MinValue==A174BUS_FBA) && ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A103BUS_IDT, out  AV32error_2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32error_2", StringUtil.Str( (decimal)(AV32error_2), 1, 0));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32error_2), 1, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      public void Valid_Bus_emp( String GX_Parm1 ,
                                 String GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 ,
                                 DateTime GX_Parm5 ,
                                 DateTime GX_Parm6 ,
                                 String GX_Parm7 ,
                                 String GX_Parm8 )
      {
         Gx_mode = GX_Parm1 ;
         A8BUS_EMP = GX_Parm2 ;
         n8BUS_EMP = false ;
         A1BUS_RUB = GX_Parm3 ;
         n1BUS_RUB = false ;
         A54BUS_DES = GX_Parm4 ;
         A170BUS_FAL = GX_Parm5 ;
         A55BUS_FAD = GX_Parm6 ;
         A333BUS_NCO = GX_Parm7 ;
         A331BUS_COM = GX_Parm8 ;
         if ( ( ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ( true /* After */ ) && ( ( ( NumberUtil.Val( AV23SESION.Get("nro_lectura"), ".") ) == Convert.ToDecimal( 0 )) ) ) )
         {
            new pbus021(context ).execute( out  A1BUS_RUB, out  A54BUS_DES, out  A170BUS_FAL, out  A55BUS_FAD, out  A333BUS_NCO, out  A331BUS_COM) ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A54BUS_DES)));
         isValidOutput.Add((Object)(context.localUtil.Format(A170BUS_FAL, "99/99/9999")));
         isValidOutput.Add((Object)(context.localUtil.Format(A55BUS_FAD, "99/99/9999")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A333BUS_NCO)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A331BUS_COM)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Bus_rub( short GX_Parm1 ,
                                 String GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A1BUS_RUB = GX_Parm1 ;
         n1BUS_RUB = false ;
         A61BUS_RUD = GX_Parm2 ;
         n61BUS_RUD = false ;
         A178BUS_AMO = GX_Parm3 ;
         n178BUS_AMO = false ;
         /* Using cursor T000O14 */
         pr_default.execute(12, new Object[] {n1BUS_RUB, A1BUS_RUB});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'RUBRO BIENES DE USO'.", "ForeignKeyNotFound", 1, "BUS_RUB");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_RUB_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A61BUS_RUD = T000O14_A61BUS_RUD[0] ;
            n61BUS_RUD = T000O14_n61BUS_RUD[0] ;
            A178BUS_AMO = T000O14_A178BUS_AMO[0] ;
            n178BUS_AMO = T000O14_n178BUS_AMO[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A61BUS_RUD = "" ;
            n61BUS_RUD = false ;
            A178BUS_AMO = "" ;
            n178BUS_AMO = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A61BUS_RUD)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A178BUS_AMO)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Bus_par( String GX_Parm1 ,
                                 short GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 ,
                                 short GX_Parm5 ,
                                 short GX_Parm6 )
      {
         Gx_mode = GX_Parm1 ;
         A3BUS_COD = GX_Parm2 ;
         n3BUS_COD = false ;
         A1BUS_RUB = GX_Parm3 ;
         n1BUS_RUB = false ;
         A8BUS_EMP = GX_Parm4 ;
         n8BUS_EMP = false ;
         A4BUS_PAR = GX_Parm5 ;
         n4BUS_PAR = false ;
         AV16error = GX_Parm6 ;
         if ( true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            new ptbus000(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR, out  AV16error) ;
         }
         if ( ( AV16error == 1 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("Ya existe el bien que está intentando cargar.", 1, "BUS_PAR");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_PAR_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16error), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Bus_fba( int GX_Parm1 ,
                                 DateTime GX_Parm2 ,
                                 short GX_Parm3 )
      {
         A103BUS_IDT = GX_Parm1 ;
         A174BUS_FBA = GX_Parm2 ;
         AV32error_2 = GX_Parm3 ;
         if ( ! ( (DateTime.MinValue==A174BUS_FBA) || ( A174BUS_FBA >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE BAJA DEL BIEN fuera de rango", "OutOfRange", 1, "BUS_FBA");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_FBA_Internalname ;
         }
         if ( ! (DateTime.MinValue==A174BUS_FBA) && ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A103BUS_IDT, out  AV32error_2) ;
         }
         if ( ( AV32error_2 == 1 ) && ! (DateTime.MinValue==A174BUS_FBA) && ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem("No puede dar de baja este bien porque no está dado de baja en trazabilidad de bienes de uso.", 1, "BUS_FBA");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_FBA_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32error_2), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Bus_idt( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 ,
                                 int GX_Parm5 ,
                                 short GX_Parm6 ,
                                 String GX_Parm7 )
      {
         A4BUS_PAR = GX_Parm1 ;
         n4BUS_PAR = false ;
         A3BUS_COD = GX_Parm2 ;
         n3BUS_COD = false ;
         A1BUS_RUB = GX_Parm3 ;
         n1BUS_RUB = false ;
         A8BUS_EMP = GX_Parm4 ;
         n8BUS_EMP = false ;
         A103BUS_IDT = GX_Parm5 ;
         AV31error_t = GX_Parm6 ;
         AV30mensaje = GX_Parm7 ;
         if ( ( A103BUS_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_2(context ).execute(  A8BUS_EMP,  A1BUS_RUB,  A3BUS_COD,  A4BUS_PAR,  A103BUS_IDT, out  AV31error_t, out  AV30mensaje) ;
         }
         if ( ( A103BUS_IDT != 0 ) && ( AV31error_t == 1 ) && true /* After */ )
         {
            GX_msglist.addItem(AV30mensaje, 1, "BUS_IDT");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_IDT_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31error_t), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV30mensaje)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(14);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV8BUS_EMP = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A8BUS_EMP = "" ;
         A54BUS_DES = "" ;
         A170BUS_FAL = DateTime.MinValue ;
         A55BUS_FAD = DateTime.MinValue ;
         A333BUS_NCO = "" ;
         A331BUS_COM = "" ;
         A174BUS_FBA = DateTime.MinValue ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockbus_fpr_Jsonclick = "" ;
         A340BUS_FPR = DateTime.MinValue ;
         lblTextblockbus_vut_Jsonclick = "" ;
         lblTextblockbus_coe_Jsonclick = "" ;
         lblTextblockbus_voc_Jsonclick = "" ;
         lblTextblockbus_voa_Jsonclick = "" ;
         lblTextblockbus_aaa_Jsonclick = "" ;
         lblTextblockbus_aea_Jsonclick = "" ;
         lblTextblockbus_aea2_Jsonclick = "" ;
         lblTextblockbus_aea3_Jsonclick = "" ;
         A343BUS_VHF = DateTime.MinValue ;
         lblTextblockbus_voh_Jsonclick = "" ;
         lblTextblockbus_aah_Jsonclick = "" ;
         lblTextblockbus_aeh_Jsonclick = "" ;
         lblTextblockbus_vra_Jsonclick = "" ;
         lblTextblockbus_vrh_Jsonclick = "" ;
         lblTextblockbus_vur_Jsonclick = "" ;
         lblTextblockbus_emp_Jsonclick = "" ;
         lblTextblockbus_rub_Jsonclick = "" ;
         lblTextblockbus_cod_Jsonclick = "" ;
         lblTextblockbus_des_Jsonclick = "" ;
         lblTextblockbus_fal_Jsonclick = "" ;
         lblTextblockbus_fad_Jsonclick = "" ;
         lblTextblockbus_vua_Jsonclick = "" ;
         lblTextblockbus_vao_Jsonclick = "" ;
         lblTextblockbus_com_Jsonclick = "" ;
         A350BUS_CBD = "" ;
         lblTextblockbus_nco_Jsonclick = "" ;
         lblTextblockbus_sec_Jsonclick = "" ;
         A176BUS_SED = "" ;
         lblTextblockbus_are_Jsonclick = "" ;
         A175BUS_ARD = "" ;
         lblTextblockbus_tip_Jsonclick = "" ;
         A59BUS_TID = "" ;
         lblTextblockbus_fba_Jsonclick = "" ;
         lblTextblockbus_mba_Jsonclick = "" ;
         A334BUS_MBA = "" ;
         lblTextblock2_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z8BUS_EMP = "" ;
         Z54BUS_DES = "" ;
         Z170BUS_FAL = DateTime.MinValue ;
         Z55BUS_FAD = DateTime.MinValue ;
         Z333BUS_NCO = "" ;
         Z331BUS_COM = "" ;
         Z350BUS_CBD = "" ;
         Z175BUS_ARD = "" ;
         Z176BUS_SED = "" ;
         Z59BUS_TID = "" ;
         Z174BUS_FBA = DateTime.MinValue ;
         Z334BUS_MBA = "" ;
         Z340BUS_FPR = DateTime.MinValue ;
         Z343BUS_VHF = DateTime.MinValue ;
         N331BUS_COM = "" ;
         AV18Insert_BUS_COM = "" ;
         AV30mensaje = "" ;
         A61BUS_RUD = "" ;
         A178BUS_AMO = "" ;
         AV34Pgmname = "" ;
         sMode24 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV15Context = new loadcontext(context).executeUdp( ) ;
         AV27USUARIO = "" ;
         AV25TrnContext = new SdtTransactionContext(context);
         AV28WebSession = new GxWebSession( context);
         AV26TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9BUS_IDT = 0 ;
         AV23SESION = new GxWebSession( context);
         Z61BUS_RUD = "" ;
         Z178BUS_AMO = "" ;
         T000O4_A61BUS_RUD = new String[] {""} ;
         T000O4_n61BUS_RUD = new bool[] {false} ;
         T000O4_A178BUS_AMO = new String[] {""} ;
         T000O4_n178BUS_AMO = new bool[] {false} ;
         T000O5_A8BUS_EMP = new String[] {""} ;
         T000O5_n8BUS_EMP = new bool[] {false} ;
         T000O5_A3BUS_COD = new short[1] ;
         T000O5_n3BUS_COD = new bool[] {false} ;
         T000O5_A4BUS_PAR = new short[1] ;
         T000O5_n4BUS_PAR = new bool[] {false} ;
         T000O5_A54BUS_DES = new String[] {""} ;
         T000O5_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         T000O5_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         T000O5_A333BUS_NCO = new String[] {""} ;
         T000O5_A331BUS_COM = new String[] {""} ;
         T000O5_A171BUS_ARE = new short[1] ;
         T000O5_A172BUS_SEC = new short[1] ;
         T000O5_A56BUS_TIP = new short[1] ;
         T000O5_A61BUS_RUD = new String[] {""} ;
         T000O5_n61BUS_RUD = new bool[] {false} ;
         T000O5_A178BUS_AMO = new String[] {""} ;
         T000O5_n178BUS_AMO = new bool[] {false} ;
         T000O5_A329BUS_VUA = new short[1] ;
         T000O5_A330BUS_VAO = new decimal[1] ;
         T000O5_A350BUS_CBD = new String[] {""} ;
         T000O5_A175BUS_ARD = new String[] {""} ;
         T000O5_A176BUS_SED = new String[] {""} ;
         T000O5_A59BUS_TID = new String[] {""} ;
         T000O5_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         T000O5_A334BUS_MBA = new String[] {""} ;
         T000O5_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         T000O5_A335BUS_VUT = new short[1] ;
         T000O5_A336BUS_COE = new decimal[1] ;
         T000O5_A341BUS_VOC = new decimal[1] ;
         T000O5_A337BUS_VOA = new decimal[1] ;
         T000O5_A338BUS_AAA = new decimal[1] ;
         T000O5_A339BUS_AEA = new decimal[1] ;
         T000O5_A342BUS_VAH = new decimal[1] ;
         T000O5_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         T000O5_A344BUS_VOH = new decimal[1] ;
         T000O5_A345BUS_AAH = new decimal[1] ;
         T000O5_A346BUS_AEH = new decimal[1] ;
         T000O5_A103BUS_IDT = new int[1] ;
         T000O5_A1BUS_RUB = new short[1] ;
         T000O5_n1BUS_RUB = new bool[] {false} ;
         T000O6_A61BUS_RUD = new String[] {""} ;
         T000O6_n61BUS_RUD = new bool[] {false} ;
         T000O6_A178BUS_AMO = new String[] {""} ;
         T000O6_n178BUS_AMO = new bool[] {false} ;
         T000O7_A8BUS_EMP = new String[] {""} ;
         T000O7_n8BUS_EMP = new bool[] {false} ;
         T000O7_A1BUS_RUB = new short[1] ;
         T000O7_n1BUS_RUB = new bool[] {false} ;
         T000O7_A3BUS_COD = new short[1] ;
         T000O7_n3BUS_COD = new bool[] {false} ;
         T000O7_A4BUS_PAR = new short[1] ;
         T000O7_n4BUS_PAR = new bool[] {false} ;
         T000O3_A8BUS_EMP = new String[] {""} ;
         T000O3_n8BUS_EMP = new bool[] {false} ;
         T000O3_A3BUS_COD = new short[1] ;
         T000O3_n3BUS_COD = new bool[] {false} ;
         T000O3_A4BUS_PAR = new short[1] ;
         T000O3_n4BUS_PAR = new bool[] {false} ;
         T000O3_A54BUS_DES = new String[] {""} ;
         T000O3_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         T000O3_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         T000O3_A333BUS_NCO = new String[] {""} ;
         T000O3_A331BUS_COM = new String[] {""} ;
         T000O3_A171BUS_ARE = new short[1] ;
         T000O3_A172BUS_SEC = new short[1] ;
         T000O3_A56BUS_TIP = new short[1] ;
         T000O3_A329BUS_VUA = new short[1] ;
         T000O3_A330BUS_VAO = new decimal[1] ;
         T000O3_A350BUS_CBD = new String[] {""} ;
         T000O3_A175BUS_ARD = new String[] {""} ;
         T000O3_A176BUS_SED = new String[] {""} ;
         T000O3_A59BUS_TID = new String[] {""} ;
         T000O3_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         T000O3_A334BUS_MBA = new String[] {""} ;
         T000O3_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         T000O3_A335BUS_VUT = new short[1] ;
         T000O3_A336BUS_COE = new decimal[1] ;
         T000O3_A341BUS_VOC = new decimal[1] ;
         T000O3_A337BUS_VOA = new decimal[1] ;
         T000O3_A338BUS_AAA = new decimal[1] ;
         T000O3_A339BUS_AEA = new decimal[1] ;
         T000O3_A342BUS_VAH = new decimal[1] ;
         T000O3_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         T000O3_A344BUS_VOH = new decimal[1] ;
         T000O3_A345BUS_AAH = new decimal[1] ;
         T000O3_A346BUS_AEH = new decimal[1] ;
         T000O3_A103BUS_IDT = new int[1] ;
         T000O3_A1BUS_RUB = new short[1] ;
         T000O3_n1BUS_RUB = new bool[] {false} ;
         T000O8_A8BUS_EMP = new String[] {""} ;
         T000O8_n8BUS_EMP = new bool[] {false} ;
         T000O8_A1BUS_RUB = new short[1] ;
         T000O8_n1BUS_RUB = new bool[] {false} ;
         T000O8_A3BUS_COD = new short[1] ;
         T000O8_n3BUS_COD = new bool[] {false} ;
         T000O8_A4BUS_PAR = new short[1] ;
         T000O8_n4BUS_PAR = new bool[] {false} ;
         T000O9_A8BUS_EMP = new String[] {""} ;
         T000O9_n8BUS_EMP = new bool[] {false} ;
         T000O9_A1BUS_RUB = new short[1] ;
         T000O9_n1BUS_RUB = new bool[] {false} ;
         T000O9_A3BUS_COD = new short[1] ;
         T000O9_n3BUS_COD = new bool[] {false} ;
         T000O9_A4BUS_PAR = new short[1] ;
         T000O9_n4BUS_PAR = new bool[] {false} ;
         T000O10_A8BUS_EMP = new String[] {""} ;
         T000O10_n8BUS_EMP = new bool[] {false} ;
         T000O10_A3BUS_COD = new short[1] ;
         T000O10_n3BUS_COD = new bool[] {false} ;
         T000O10_A4BUS_PAR = new short[1] ;
         T000O10_n4BUS_PAR = new bool[] {false} ;
         T000O10_A54BUS_DES = new String[] {""} ;
         T000O10_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         T000O10_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         T000O10_A333BUS_NCO = new String[] {""} ;
         T000O10_A331BUS_COM = new String[] {""} ;
         T000O10_A171BUS_ARE = new short[1] ;
         T000O10_A172BUS_SEC = new short[1] ;
         T000O10_A56BUS_TIP = new short[1] ;
         T000O10_A329BUS_VUA = new short[1] ;
         T000O10_A330BUS_VAO = new decimal[1] ;
         T000O10_A350BUS_CBD = new String[] {""} ;
         T000O10_A175BUS_ARD = new String[] {""} ;
         T000O10_A176BUS_SED = new String[] {""} ;
         T000O10_A59BUS_TID = new String[] {""} ;
         T000O10_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         T000O10_A334BUS_MBA = new String[] {""} ;
         T000O10_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         T000O10_A335BUS_VUT = new short[1] ;
         T000O10_A336BUS_COE = new decimal[1] ;
         T000O10_A341BUS_VOC = new decimal[1] ;
         T000O10_A337BUS_VOA = new decimal[1] ;
         T000O10_A338BUS_AAA = new decimal[1] ;
         T000O10_A339BUS_AEA = new decimal[1] ;
         T000O10_A342BUS_VAH = new decimal[1] ;
         T000O10_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         T000O10_A344BUS_VOH = new decimal[1] ;
         T000O10_A345BUS_AAH = new decimal[1] ;
         T000O10_A346BUS_AEH = new decimal[1] ;
         T000O10_A103BUS_IDT = new int[1] ;
         T000O10_A1BUS_RUB = new short[1] ;
         T000O10_n1BUS_RUB = new bool[] {false} ;
         T000O14_A61BUS_RUD = new String[] {""} ;
         T000O14_n61BUS_RUD = new bool[] {false} ;
         T000O14_A178BUS_AMO = new String[] {""} ;
         T000O14_n178BUS_AMO = new bool[] {false} ;
         T000O15_A11TTBUS_Id = new int[1] ;
         T000O16_A8BUS_EMP = new String[] {""} ;
         T000O16_n8BUS_EMP = new bool[] {false} ;
         T000O16_A1BUS_RUB = new short[1] ;
         T000O16_n1BUS_RUB = new bool[] {false} ;
         T000O16_A3BUS_COD = new short[1] ;
         T000O16_n3BUS_COD = new bool[] {false} ;
         T000O16_A4BUS_PAR = new short[1] ;
         T000O16_n4BUS_PAR = new bool[] {false} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tbus000__default(),
            new Object[][] {
                new Object[] {
               T000O2_A8BUS_EMP, T000O2_A3BUS_COD, T000O2_A4BUS_PAR, T000O2_A54BUS_DES, T000O2_A170BUS_FAL, T000O2_A55BUS_FAD, T000O2_A333BUS_NCO, T000O2_A331BUS_COM, T000O2_A171BUS_ARE, T000O2_A172BUS_SEC,
               T000O2_A56BUS_TIP, T000O2_A329BUS_VUA, T000O2_A330BUS_VAO, T000O2_A350BUS_CBD, T000O2_A175BUS_ARD, T000O2_A176BUS_SED, T000O2_A59BUS_TID, T000O2_A174BUS_FBA, T000O2_A334BUS_MBA, T000O2_A340BUS_FPR,
               T000O2_A335BUS_VUT, T000O2_A336BUS_COE, T000O2_A341BUS_VOC, T000O2_A337BUS_VOA, T000O2_A338BUS_AAA, T000O2_A339BUS_AEA, T000O2_A342BUS_VAH, T000O2_A343BUS_VHF, T000O2_A344BUS_VOH, T000O2_A345BUS_AAH,
               T000O2_A346BUS_AEH, T000O2_A103BUS_IDT, T000O2_A1BUS_RUB
               }
               , new Object[] {
               T000O3_A8BUS_EMP, T000O3_A3BUS_COD, T000O3_A4BUS_PAR, T000O3_A54BUS_DES, T000O3_A170BUS_FAL, T000O3_A55BUS_FAD, T000O3_A333BUS_NCO, T000O3_A331BUS_COM, T000O3_A171BUS_ARE, T000O3_A172BUS_SEC,
               T000O3_A56BUS_TIP, T000O3_A329BUS_VUA, T000O3_A330BUS_VAO, T000O3_A350BUS_CBD, T000O3_A175BUS_ARD, T000O3_A176BUS_SED, T000O3_A59BUS_TID, T000O3_A174BUS_FBA, T000O3_A334BUS_MBA, T000O3_A340BUS_FPR,
               T000O3_A335BUS_VUT, T000O3_A336BUS_COE, T000O3_A341BUS_VOC, T000O3_A337BUS_VOA, T000O3_A338BUS_AAA, T000O3_A339BUS_AEA, T000O3_A342BUS_VAH, T000O3_A343BUS_VHF, T000O3_A344BUS_VOH, T000O3_A345BUS_AAH,
               T000O3_A346BUS_AEH, T000O3_A103BUS_IDT, T000O3_A1BUS_RUB
               }
               , new Object[] {
               T000O4_A61BUS_RUD, T000O4_n61BUS_RUD, T000O4_A178BUS_AMO, T000O4_n178BUS_AMO
               }
               , new Object[] {
               T000O5_A8BUS_EMP, T000O5_A3BUS_COD, T000O5_A4BUS_PAR, T000O5_A54BUS_DES, T000O5_A170BUS_FAL, T000O5_A55BUS_FAD, T000O5_A333BUS_NCO, T000O5_A331BUS_COM, T000O5_A171BUS_ARE, T000O5_A172BUS_SEC,
               T000O5_A56BUS_TIP, T000O5_A61BUS_RUD, T000O5_n61BUS_RUD, T000O5_A178BUS_AMO, T000O5_n178BUS_AMO, T000O5_A329BUS_VUA, T000O5_A330BUS_VAO, T000O5_A350BUS_CBD, T000O5_A175BUS_ARD, T000O5_A176BUS_SED,
               T000O5_A59BUS_TID, T000O5_A174BUS_FBA, T000O5_A334BUS_MBA, T000O5_A340BUS_FPR, T000O5_A335BUS_VUT, T000O5_A336BUS_COE, T000O5_A341BUS_VOC, T000O5_A337BUS_VOA, T000O5_A338BUS_AAA, T000O5_A339BUS_AEA,
               T000O5_A342BUS_VAH, T000O5_A343BUS_VHF, T000O5_A344BUS_VOH, T000O5_A345BUS_AAH, T000O5_A346BUS_AEH, T000O5_A103BUS_IDT, T000O5_A1BUS_RUB
               }
               , new Object[] {
               T000O6_A61BUS_RUD, T000O6_n61BUS_RUD, T000O6_A178BUS_AMO, T000O6_n178BUS_AMO
               }
               , new Object[] {
               T000O7_A8BUS_EMP, T000O7_A1BUS_RUB, T000O7_A3BUS_COD, T000O7_A4BUS_PAR
               }
               , new Object[] {
               T000O8_A8BUS_EMP, T000O8_A1BUS_RUB, T000O8_A3BUS_COD, T000O8_A4BUS_PAR
               }
               , new Object[] {
               T000O9_A8BUS_EMP, T000O9_A1BUS_RUB, T000O9_A3BUS_COD, T000O9_A4BUS_PAR
               }
               , new Object[] {
               T000O10_A8BUS_EMP, T000O10_A3BUS_COD, T000O10_A4BUS_PAR, T000O10_A54BUS_DES, T000O10_A170BUS_FAL, T000O10_A55BUS_FAD, T000O10_A333BUS_NCO, T000O10_A331BUS_COM, T000O10_A171BUS_ARE, T000O10_A172BUS_SEC,
               T000O10_A56BUS_TIP, T000O10_A329BUS_VUA, T000O10_A330BUS_VAO, T000O10_A350BUS_CBD, T000O10_A175BUS_ARD, T000O10_A176BUS_SED, T000O10_A59BUS_TID, T000O10_A174BUS_FBA, T000O10_A334BUS_MBA, T000O10_A340BUS_FPR,
               T000O10_A335BUS_VUT, T000O10_A336BUS_COE, T000O10_A341BUS_VOC, T000O10_A337BUS_VOA, T000O10_A338BUS_AAA, T000O10_A339BUS_AEA, T000O10_A342BUS_VAH, T000O10_A343BUS_VHF, T000O10_A344BUS_VOH, T000O10_A345BUS_AAH,
               T000O10_A346BUS_AEH, T000O10_A103BUS_IDT, T000O10_A1BUS_RUB
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O14_A61BUS_RUD, T000O14_n61BUS_RUD, T000O14_A178BUS_AMO, T000O14_n178BUS_AMO
               }
               , new Object[] {
               T000O15_A11TTBUS_Id
               }
               , new Object[] {
               T000O16_A8BUS_EMP, T000O16_A1BUS_RUB, T000O16_A3BUS_COD, T000O16_A4BUS_PAR
               }
            }
         );
         Z103BUS_IDT = 0 ;
         AV34Pgmname = "TBUS000" ;
         Z8BUS_EMP = "M" ;
         n8BUS_EMP = false ;
      }

      private short wcpOAV11BUS_RUB ;
      private short wcpOAV7BUS_COD ;
      private short wcpOAV10BUS_PAR ;
      private short GxWebError ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short AV11BUS_RUB ;
      private short AV7BUS_COD ;
      private short AV10BUS_PAR ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A335BUS_VUT ;
      private short A349BUS_VUR ;
      private short A329BUS_VUA ;
      private short A172BUS_SEC ;
      private short A171BUS_ARE ;
      private short A56BUS_TIP ;
      private short Z1BUS_RUB ;
      private short Z3BUS_COD ;
      private short Z4BUS_PAR ;
      private short Z171BUS_ARE ;
      private short Z172BUS_SEC ;
      private short Z56BUS_TIP ;
      private short Z329BUS_VUA ;
      private short Z335BUS_VUT ;
      private short N171BUS_ARE ;
      private short N172BUS_SEC ;
      private short N56BUS_TIP ;
      private short Gx_BScreen ;
      private short AV17Insert_BUS_ARE ;
      private short AV19Insert_BUS_SEC ;
      private short AV20Insert_BUS_TIP ;
      private short AV16error ;
      private short AV31error_t ;
      private short AV32error_2 ;
      private short RcdFound24 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private int A103BUS_IDT ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int tblTableprocesos_Visible ;
      private int edtBUS_FPR_Enabled ;
      private int edtBUS_VUT_Enabled ;
      private int edtBUS_COE_Enabled ;
      private int edtBUS_VOC_Enabled ;
      private int edtBUS_VOA_Enabled ;
      private int edtBUS_AAA_Enabled ;
      private int edtBUS_AEA_Enabled ;
      private int edtBUS_VAH_Enabled ;
      private int edtBUS_VHF_Enabled ;
      private int edtBUS_VOH_Enabled ;
      private int edtBUS_AAH_Enabled ;
      private int edtBUS_AEH_Enabled ;
      private int edtBUS_VRA_Enabled ;
      private int edtBUS_VRH_Enabled ;
      private int edtBUS_VUR_Enabled ;
      private int edtBUS_EMP_Enabled ;
      private int edtBUS_RUB_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtBUS_COD_Enabled ;
      private int edtBUS_PAR_Enabled ;
      private int edtBUS_DES_Enabled ;
      private int edtBUS_FAL_Enabled ;
      private int edtBUS_FAD_Enabled ;
      private int edtBUS_VUA_Enabled ;
      private int edtBUS_VAO_Enabled ;
      private int edtBUS_COM_Enabled ;
      private int edtBUS_CBD_Enabled ;
      private int edtBUS_NCO_Enabled ;
      private int edtBUS_SEC_Enabled ;
      private int edtBUS_SED_Enabled ;
      private int edtBUS_ARE_Enabled ;
      private int edtBUS_ARD_Enabled ;
      private int edtBUS_TIP_Enabled ;
      private int edtBUS_TID_Enabled ;
      private int edtBUS_FBA_Enabled ;
      private int edtBUS_MBA_Enabled ;
      private int edtBUS_IDT_Enabled ;
      private int imgprompt_103_Visible ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int Z103BUS_IDT ;
      private int AV35GXV1 ;
      private int AV9BUS_IDT ;
      private int i103BUS_IDT ;
      private int idxLst ;
      private decimal A336BUS_COE ;
      private decimal A341BUS_VOC ;
      private decimal A337BUS_VOA ;
      private decimal A338BUS_AAA ;
      private decimal A339BUS_AEA ;
      private decimal A342BUS_VAH ;
      private decimal A344BUS_VOH ;
      private decimal A345BUS_AAH ;
      private decimal A346BUS_AEH ;
      private decimal A347BUS_VRA ;
      private decimal A348BUS_VRH ;
      private decimal A330BUS_VAO ;
      private decimal Z330BUS_VAO ;
      private decimal Z336BUS_COE ;
      private decimal Z341BUS_VOC ;
      private decimal Z337BUS_VOA ;
      private decimal Z338BUS_AAA ;
      private decimal Z339BUS_AEA ;
      private decimal Z342BUS_VAH ;
      private decimal Z344BUS_VOH ;
      private decimal Z345BUS_AAH ;
      private decimal Z346BUS_AEH ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV8BUS_EMP ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String A8BUS_EMP ;
      private String A54BUS_DES ;
      private String A333BUS_NCO ;
      private String A331BUS_COM ;
      private String AV8BUS_EMP ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBUS_EMP_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTableprocesos_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTextblockbus_fpr_Internalname ;
      private String lblTextblockbus_fpr_Jsonclick ;
      private String edtBUS_FPR_Internalname ;
      private String edtBUS_FPR_Jsonclick ;
      private String lblTextblockbus_vut_Internalname ;
      private String lblTextblockbus_vut_Jsonclick ;
      private String edtBUS_VUT_Internalname ;
      private String edtBUS_VUT_Jsonclick ;
      private String lblTextblockbus_coe_Internalname ;
      private String lblTextblockbus_coe_Jsonclick ;
      private String edtBUS_COE_Internalname ;
      private String edtBUS_COE_Jsonclick ;
      private String lblTextblockbus_voc_Internalname ;
      private String lblTextblockbus_voc_Jsonclick ;
      private String edtBUS_VOC_Internalname ;
      private String edtBUS_VOC_Jsonclick ;
      private String lblTextblockbus_voa_Internalname ;
      private String lblTextblockbus_voa_Jsonclick ;
      private String edtBUS_VOA_Internalname ;
      private String edtBUS_VOA_Jsonclick ;
      private String lblTextblockbus_aaa_Internalname ;
      private String lblTextblockbus_aaa_Jsonclick ;
      private String edtBUS_AAA_Internalname ;
      private String edtBUS_AAA_Jsonclick ;
      private String lblTextblockbus_aea_Internalname ;
      private String lblTextblockbus_aea_Jsonclick ;
      private String edtBUS_AEA_Internalname ;
      private String edtBUS_AEA_Jsonclick ;
      private String lblTextblockbus_aea2_Internalname ;
      private String lblTextblockbus_aea2_Jsonclick ;
      private String edtBUS_VAH_Internalname ;
      private String edtBUS_VAH_Jsonclick ;
      private String lblTextblockbus_aea3_Internalname ;
      private String lblTextblockbus_aea3_Jsonclick ;
      private String edtBUS_VHF_Internalname ;
      private String edtBUS_VHF_Jsonclick ;
      private String lblTextblockbus_voh_Internalname ;
      private String lblTextblockbus_voh_Jsonclick ;
      private String edtBUS_VOH_Internalname ;
      private String edtBUS_VOH_Jsonclick ;
      private String lblTextblockbus_aah_Internalname ;
      private String lblTextblockbus_aah_Jsonclick ;
      private String edtBUS_AAH_Internalname ;
      private String edtBUS_AAH_Jsonclick ;
      private String lblTextblockbus_aeh_Internalname ;
      private String lblTextblockbus_aeh_Jsonclick ;
      private String edtBUS_AEH_Internalname ;
      private String edtBUS_AEH_Jsonclick ;
      private String lblTextblockbus_vra_Internalname ;
      private String lblTextblockbus_vra_Jsonclick ;
      private String edtBUS_VRA_Internalname ;
      private String edtBUS_VRA_Jsonclick ;
      private String lblTextblockbus_vrh_Internalname ;
      private String lblTextblockbus_vrh_Jsonclick ;
      private String edtBUS_VRH_Internalname ;
      private String edtBUS_VRH_Jsonclick ;
      private String lblTextblockbus_vur_Internalname ;
      private String lblTextblockbus_vur_Jsonclick ;
      private String edtBUS_VUR_Internalname ;
      private String edtBUS_VUR_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockbus_emp_Internalname ;
      private String lblTextblockbus_emp_Jsonclick ;
      private String edtBUS_EMP_Jsonclick ;
      private String lblTextblockbus_rub_Internalname ;
      private String lblTextblockbus_rub_Jsonclick ;
      private String edtBUS_RUB_Internalname ;
      private String edtBUS_RUB_Jsonclick ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String lblTextblockbus_cod_Internalname ;
      private String lblTextblockbus_cod_Jsonclick ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_COD_Jsonclick ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_PAR_Jsonclick ;
      private String lblTextblockbus_des_Internalname ;
      private String lblTextblockbus_des_Jsonclick ;
      private String edtBUS_DES_Internalname ;
      private String edtBUS_DES_Jsonclick ;
      private String lblTextblockbus_fal_Internalname ;
      private String lblTextblockbus_fal_Jsonclick ;
      private String edtBUS_FAL_Internalname ;
      private String edtBUS_FAL_Jsonclick ;
      private String lblTextblockbus_fad_Internalname ;
      private String lblTextblockbus_fad_Jsonclick ;
      private String edtBUS_FAD_Internalname ;
      private String edtBUS_FAD_Jsonclick ;
      private String lblTextblockbus_vua_Internalname ;
      private String lblTextblockbus_vua_Jsonclick ;
      private String edtBUS_VUA_Internalname ;
      private String edtBUS_VUA_Jsonclick ;
      private String lblTextblockbus_vao_Internalname ;
      private String lblTextblockbus_vao_Jsonclick ;
      private String edtBUS_VAO_Internalname ;
      private String edtBUS_VAO_Jsonclick ;
      private String lblTextblockbus_com_Internalname ;
      private String lblTextblockbus_com_Jsonclick ;
      private String edtBUS_COM_Internalname ;
      private String edtBUS_COM_Jsonclick ;
      private String edtBUS_CBD_Internalname ;
      private String A350BUS_CBD ;
      private String edtBUS_CBD_Jsonclick ;
      private String lblTextblockbus_nco_Internalname ;
      private String lblTextblockbus_nco_Jsonclick ;
      private String edtBUS_NCO_Internalname ;
      private String edtBUS_NCO_Jsonclick ;
      private String lblTextblockbus_sec_Internalname ;
      private String lblTextblockbus_sec_Jsonclick ;
      private String edtBUS_SEC_Internalname ;
      private String edtBUS_SEC_Jsonclick ;
      private String edtBUS_SED_Internalname ;
      private String A176BUS_SED ;
      private String edtBUS_SED_Jsonclick ;
      private String lblTextblockbus_are_Internalname ;
      private String lblTextblockbus_are_Jsonclick ;
      private String edtBUS_ARE_Internalname ;
      private String edtBUS_ARE_Jsonclick ;
      private String edtBUS_ARD_Internalname ;
      private String A175BUS_ARD ;
      private String edtBUS_ARD_Jsonclick ;
      private String lblTextblockbus_tip_Internalname ;
      private String lblTextblockbus_tip_Jsonclick ;
      private String edtBUS_TIP_Internalname ;
      private String edtBUS_TIP_Jsonclick ;
      private String edtBUS_TID_Internalname ;
      private String A59BUS_TID ;
      private String edtBUS_TID_Jsonclick ;
      private String lblTextblockbus_fba_Internalname ;
      private String lblTextblockbus_fba_Jsonclick ;
      private String edtBUS_FBA_Internalname ;
      private String edtBUS_FBA_Jsonclick ;
      private String lblTextblockbus_mba_Internalname ;
      private String lblTextblockbus_mba_Jsonclick ;
      private String edtBUS_MBA_Internalname ;
      private String A334BUS_MBA ;
      private String edtBUS_MBA_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtBUS_IDT_Internalname ;
      private String edtBUS_IDT_Jsonclick ;
      private String imgprompt_103_Internalname ;
      private String imgprompt_103_Link ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Z8BUS_EMP ;
      private String Z54BUS_DES ;
      private String Z333BUS_NCO ;
      private String Z331BUS_COM ;
      private String Z350BUS_CBD ;
      private String Z175BUS_ARD ;
      private String Z176BUS_SED ;
      private String Z59BUS_TID ;
      private String Z334BUS_MBA ;
      private String N331BUS_COM ;
      private String AV18Insert_BUS_COM ;
      private String AV30mensaje ;
      private String A61BUS_RUD ;
      private String A178BUS_AMO ;
      private String AV34Pgmname ;
      private String sMode24 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV27USUARIO ;
      private String Z61BUS_RUD ;
      private String Z178BUS_AMO ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private DateTime A170BUS_FAL ;
      private DateTime A55BUS_FAD ;
      private DateTime A174BUS_FBA ;
      private DateTime A340BUS_FPR ;
      private DateTime A343BUS_VHF ;
      private DateTime Z170BUS_FAL ;
      private DateTime Z55BUS_FAD ;
      private DateTime Z174BUS_FBA ;
      private DateTime Z340BUS_FPR ;
      private DateTime Z343BUS_VHF ;
      private bool entryPointCalled ;
      private bool n8BUS_EMP ;
      private bool n1BUS_RUB ;
      private bool n3BUS_COD ;
      private bool n4BUS_PAR ;
      private bool wbErr ;
      private bool n61BUS_RUD ;
      private bool n178BUS_AMO ;
      private bool AV21IsAuthorized ;
      private bool Gx_longc ;
      private GxWebSession AV28WebSession ;
      private GxWebSession AV23SESION ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000O4_A61BUS_RUD ;
      private bool[] T000O4_n61BUS_RUD ;
      private String[] T000O4_A178BUS_AMO ;
      private bool[] T000O4_n178BUS_AMO ;
      private String[] T000O5_A8BUS_EMP ;
      private bool[] T000O5_n8BUS_EMP ;
      private short[] T000O5_A3BUS_COD ;
      private bool[] T000O5_n3BUS_COD ;
      private short[] T000O5_A4BUS_PAR ;
      private bool[] T000O5_n4BUS_PAR ;
      private String[] T000O5_A54BUS_DES ;
      private DateTime[] T000O5_A170BUS_FAL ;
      private DateTime[] T000O5_A55BUS_FAD ;
      private String[] T000O5_A333BUS_NCO ;
      private String[] T000O5_A331BUS_COM ;
      private short[] T000O5_A171BUS_ARE ;
      private short[] T000O5_A172BUS_SEC ;
      private short[] T000O5_A56BUS_TIP ;
      private String[] T000O5_A61BUS_RUD ;
      private bool[] T000O5_n61BUS_RUD ;
      private String[] T000O5_A178BUS_AMO ;
      private bool[] T000O5_n178BUS_AMO ;
      private short[] T000O5_A329BUS_VUA ;
      private decimal[] T000O5_A330BUS_VAO ;
      private String[] T000O5_A350BUS_CBD ;
      private String[] T000O5_A175BUS_ARD ;
      private String[] T000O5_A176BUS_SED ;
      private String[] T000O5_A59BUS_TID ;
      private DateTime[] T000O5_A174BUS_FBA ;
      private String[] T000O5_A334BUS_MBA ;
      private DateTime[] T000O5_A340BUS_FPR ;
      private short[] T000O5_A335BUS_VUT ;
      private decimal[] T000O5_A336BUS_COE ;
      private decimal[] T000O5_A341BUS_VOC ;
      private decimal[] T000O5_A337BUS_VOA ;
      private decimal[] T000O5_A338BUS_AAA ;
      private decimal[] T000O5_A339BUS_AEA ;
      private decimal[] T000O5_A342BUS_VAH ;
      private DateTime[] T000O5_A343BUS_VHF ;
      private decimal[] T000O5_A344BUS_VOH ;
      private decimal[] T000O5_A345BUS_AAH ;
      private decimal[] T000O5_A346BUS_AEH ;
      private int[] T000O5_A103BUS_IDT ;
      private short[] T000O5_A1BUS_RUB ;
      private bool[] T000O5_n1BUS_RUB ;
      private String[] T000O6_A61BUS_RUD ;
      private bool[] T000O6_n61BUS_RUD ;
      private String[] T000O6_A178BUS_AMO ;
      private bool[] T000O6_n178BUS_AMO ;
      private String[] T000O7_A8BUS_EMP ;
      private bool[] T000O7_n8BUS_EMP ;
      private short[] T000O7_A1BUS_RUB ;
      private bool[] T000O7_n1BUS_RUB ;
      private short[] T000O7_A3BUS_COD ;
      private bool[] T000O7_n3BUS_COD ;
      private short[] T000O7_A4BUS_PAR ;
      private bool[] T000O7_n4BUS_PAR ;
      private String[] T000O3_A8BUS_EMP ;
      private bool[] T000O3_n8BUS_EMP ;
      private short[] T000O3_A3BUS_COD ;
      private bool[] T000O3_n3BUS_COD ;
      private short[] T000O3_A4BUS_PAR ;
      private bool[] T000O3_n4BUS_PAR ;
      private String[] T000O3_A54BUS_DES ;
      private DateTime[] T000O3_A170BUS_FAL ;
      private DateTime[] T000O3_A55BUS_FAD ;
      private String[] T000O3_A333BUS_NCO ;
      private String[] T000O3_A331BUS_COM ;
      private short[] T000O3_A171BUS_ARE ;
      private short[] T000O3_A172BUS_SEC ;
      private short[] T000O3_A56BUS_TIP ;
      private short[] T000O3_A329BUS_VUA ;
      private decimal[] T000O3_A330BUS_VAO ;
      private String[] T000O3_A350BUS_CBD ;
      private String[] T000O3_A175BUS_ARD ;
      private String[] T000O3_A176BUS_SED ;
      private String[] T000O3_A59BUS_TID ;
      private DateTime[] T000O3_A174BUS_FBA ;
      private String[] T000O3_A334BUS_MBA ;
      private DateTime[] T000O3_A340BUS_FPR ;
      private short[] T000O3_A335BUS_VUT ;
      private decimal[] T000O3_A336BUS_COE ;
      private decimal[] T000O3_A341BUS_VOC ;
      private decimal[] T000O3_A337BUS_VOA ;
      private decimal[] T000O3_A338BUS_AAA ;
      private decimal[] T000O3_A339BUS_AEA ;
      private decimal[] T000O3_A342BUS_VAH ;
      private DateTime[] T000O3_A343BUS_VHF ;
      private decimal[] T000O3_A344BUS_VOH ;
      private decimal[] T000O3_A345BUS_AAH ;
      private decimal[] T000O3_A346BUS_AEH ;
      private int[] T000O3_A103BUS_IDT ;
      private short[] T000O3_A1BUS_RUB ;
      private bool[] T000O3_n1BUS_RUB ;
      private String[] T000O8_A8BUS_EMP ;
      private bool[] T000O8_n8BUS_EMP ;
      private short[] T000O8_A1BUS_RUB ;
      private bool[] T000O8_n1BUS_RUB ;
      private short[] T000O8_A3BUS_COD ;
      private bool[] T000O8_n3BUS_COD ;
      private short[] T000O8_A4BUS_PAR ;
      private bool[] T000O8_n4BUS_PAR ;
      private String[] T000O9_A8BUS_EMP ;
      private bool[] T000O9_n8BUS_EMP ;
      private short[] T000O9_A1BUS_RUB ;
      private bool[] T000O9_n1BUS_RUB ;
      private short[] T000O9_A3BUS_COD ;
      private bool[] T000O9_n3BUS_COD ;
      private short[] T000O9_A4BUS_PAR ;
      private bool[] T000O9_n4BUS_PAR ;
      private String[] T000O10_A8BUS_EMP ;
      private bool[] T000O10_n8BUS_EMP ;
      private short[] T000O10_A3BUS_COD ;
      private bool[] T000O10_n3BUS_COD ;
      private short[] T000O10_A4BUS_PAR ;
      private bool[] T000O10_n4BUS_PAR ;
      private String[] T000O10_A54BUS_DES ;
      private DateTime[] T000O10_A170BUS_FAL ;
      private DateTime[] T000O10_A55BUS_FAD ;
      private String[] T000O10_A333BUS_NCO ;
      private String[] T000O10_A331BUS_COM ;
      private short[] T000O10_A171BUS_ARE ;
      private short[] T000O10_A172BUS_SEC ;
      private short[] T000O10_A56BUS_TIP ;
      private short[] T000O10_A329BUS_VUA ;
      private decimal[] T000O10_A330BUS_VAO ;
      private String[] T000O10_A350BUS_CBD ;
      private String[] T000O10_A175BUS_ARD ;
      private String[] T000O10_A176BUS_SED ;
      private String[] T000O10_A59BUS_TID ;
      private DateTime[] T000O10_A174BUS_FBA ;
      private String[] T000O10_A334BUS_MBA ;
      private DateTime[] T000O10_A340BUS_FPR ;
      private short[] T000O10_A335BUS_VUT ;
      private decimal[] T000O10_A336BUS_COE ;
      private decimal[] T000O10_A341BUS_VOC ;
      private decimal[] T000O10_A337BUS_VOA ;
      private decimal[] T000O10_A338BUS_AAA ;
      private decimal[] T000O10_A339BUS_AEA ;
      private decimal[] T000O10_A342BUS_VAH ;
      private DateTime[] T000O10_A343BUS_VHF ;
      private decimal[] T000O10_A344BUS_VOH ;
      private decimal[] T000O10_A345BUS_AAH ;
      private decimal[] T000O10_A346BUS_AEH ;
      private int[] T000O10_A103BUS_IDT ;
      private short[] T000O10_A1BUS_RUB ;
      private bool[] T000O10_n1BUS_RUB ;
      private String[] T000O14_A61BUS_RUD ;
      private bool[] T000O14_n61BUS_RUD ;
      private String[] T000O14_A178BUS_AMO ;
      private bool[] T000O14_n178BUS_AMO ;
      private int[] T000O15_A11TTBUS_Id ;
      private String[] T000O16_A8BUS_EMP ;
      private bool[] T000O16_n8BUS_EMP ;
      private short[] T000O16_A1BUS_RUB ;
      private bool[] T000O16_n1BUS_RUB ;
      private short[] T000O16_A3BUS_COD ;
      private bool[] T000O16_n3BUS_COD ;
      private short[] T000O16_A4BUS_PAR ;
      private bool[] T000O16_n4BUS_PAR ;
      private String[] T000O2_A8BUS_EMP ;
      private short[] T000O2_A3BUS_COD ;
      private short[] T000O2_A4BUS_PAR ;
      private String[] T000O2_A54BUS_DES ;
      private DateTime[] T000O2_A170BUS_FAL ;
      private DateTime[] T000O2_A55BUS_FAD ;
      private String[] T000O2_A333BUS_NCO ;
      private String[] T000O2_A331BUS_COM ;
      private short[] T000O2_A171BUS_ARE ;
      private short[] T000O2_A172BUS_SEC ;
      private short[] T000O2_A56BUS_TIP ;
      private short[] T000O2_A329BUS_VUA ;
      private decimal[] T000O2_A330BUS_VAO ;
      private String[] T000O2_A350BUS_CBD ;
      private String[] T000O2_A175BUS_ARD ;
      private String[] T000O2_A176BUS_SED ;
      private String[] T000O2_A59BUS_TID ;
      private DateTime[] T000O2_A174BUS_FBA ;
      private String[] T000O2_A334BUS_MBA ;
      private DateTime[] T000O2_A340BUS_FPR ;
      private short[] T000O2_A335BUS_VUT ;
      private decimal[] T000O2_A336BUS_COE ;
      private decimal[] T000O2_A341BUS_VOC ;
      private decimal[] T000O2_A337BUS_VOA ;
      private decimal[] T000O2_A338BUS_AAA ;
      private decimal[] T000O2_A339BUS_AEA ;
      private decimal[] T000O2_A342BUS_VAH ;
      private DateTime[] T000O2_A343BUS_VHF ;
      private decimal[] T000O2_A344BUS_VOH ;
      private decimal[] T000O2_A345BUS_AAH ;
      private decimal[] T000O2_A346BUS_AEH ;
      private int[] T000O2_A103BUS_IDT ;
      private short[] T000O2_A1BUS_RUB ;
      private GXWebForm Form ;
      private SdtContext AV15Context ;
      private SdtTransactionContext AV25TrnContext ;
      private SdtTransactionContext_Attribute AV26TrnContextAtt ;
   }

   public class tbus000__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000O2 ;
          prmT000O2 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O5 ;
          prmT000O5 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O4 ;
          prmT000O4 = new Object[] {
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O6 ;
          prmT000O6 = new Object[] {
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O7 ;
          prmT000O7 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O3 ;
          prmT000O3 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O8 ;
          prmT000O8 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O9 ;
          prmT000O9 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O10 ;
          prmT000O10 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O11 ;
          prmT000O11 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@BUS_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@BUS_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@BUS_COM",SqlDbType.Char,2,0} ,
          new Object[] {"@BUS_ARE",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_SEC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@BUS_TIP",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@BUS_VUA",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_VAO",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_CBD",SqlDbType.Char,20,0} ,
          new Object[] {"@BUS_ARD",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_SED",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_TID",SqlDbType.Char,20,0} ,
          new Object[] {"@BUS_FBA",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_MBA",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_FPR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_VUT",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COE",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VOC",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VOA",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_AAA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_AEA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_VAH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VHF",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_VOH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_AAH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_AEH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O12 ;
          prmT000O12 = new Object[] {
          new Object[] {"@BUS_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@BUS_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@BUS_COM",SqlDbType.Char,2,0} ,
          new Object[] {"@BUS_ARE",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_SEC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@BUS_TIP",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@BUS_VUA",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_VAO",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_CBD",SqlDbType.Char,20,0} ,
          new Object[] {"@BUS_ARD",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_SED",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_TID",SqlDbType.Char,20,0} ,
          new Object[] {"@BUS_FBA",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_MBA",SqlDbType.Char,30,0} ,
          new Object[] {"@BUS_FPR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_VUT",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COE",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VOC",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VOA",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_AAA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_AEA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_VAH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_VHF",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_VOH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@BUS_AAH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_AEH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BUS_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O13 ;
          prmT000O13 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O15 ;
          prmT000O15 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000O16 ;
          prmT000O16 = new Object[] {
          } ;
          Object[] prmT000O14 ;
          prmT000O14 = new Object[] {
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000O2", "SELECT [BUS_EMP], [BUS_COD], [BUS_PAR], [BUS_DES], [BUS_FAL], [BUS_FAD], [BUS_NCO], [BUS_COM], [BUS_ARE], [BUS_SEC], [BUS_TIP], [BUS_VUA], [BUS_VAO], [BUS_CBD], [BUS_ARD], [BUS_SED], [BUS_TID], [BUS_FBA], [BUS_MBA], [BUS_FPR], [BUS_VUT], [BUS_COE], [BUS_VOC], [BUS_VOA], [BUS_AAA], [BUS_AEA], [BUS_VAH], [BUS_VHF], [BUS_VOH], [BUS_AAH], [BUS_AEH], [BUS_IDT], [BUS_RUB] AS BUS_RUB FROM [BUS000] WITH (UPDLOCK) WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O2,1,0,true,false )
             ,new CursorDef("T000O3", "SELECT [BUS_EMP], [BUS_COD], [BUS_PAR], [BUS_DES], [BUS_FAL], [BUS_FAD], [BUS_NCO], [BUS_COM], [BUS_ARE], [BUS_SEC], [BUS_TIP], [BUS_VUA], [BUS_VAO], [BUS_CBD], [BUS_ARD], [BUS_SED], [BUS_TID], [BUS_FBA], [BUS_MBA], [BUS_FPR], [BUS_VUT], [BUS_COE], [BUS_VOC], [BUS_VOA], [BUS_AAA], [BUS_AEA], [BUS_VAH], [BUS_VHF], [BUS_VOH], [BUS_AAH], [BUS_AEH], [BUS_IDT], [BUS_RUB] AS BUS_RUB FROM [BUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O3,1,0,true,false )
             ,new CursorDef("T000O4", "SELECT [RBR_DES] AS BUS_RUD, [RBR_AMO] AS BUS_AMO FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @BUS_RUB ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O4,1,0,true,false )
             ,new CursorDef("T000O5", "SELECT TM1.[BUS_EMP], TM1.[BUS_COD], TM1.[BUS_PAR], TM1.[BUS_DES], TM1.[BUS_FAL], TM1.[BUS_FAD], TM1.[BUS_NCO], TM1.[BUS_COM], TM1.[BUS_ARE], TM1.[BUS_SEC], TM1.[BUS_TIP], T2.[RBR_DES] AS BUS_RUD, T2.[RBR_AMO] AS BUS_AMO, TM1.[BUS_VUA], TM1.[BUS_VAO], TM1.[BUS_CBD], TM1.[BUS_ARD], TM1.[BUS_SED], TM1.[BUS_TID], TM1.[BUS_FBA], TM1.[BUS_MBA], TM1.[BUS_FPR], TM1.[BUS_VUT], TM1.[BUS_COE], TM1.[BUS_VOC], TM1.[BUS_VOA], TM1.[BUS_AAA], TM1.[BUS_AEA], TM1.[BUS_VAH], TM1.[BUS_VHF], TM1.[BUS_VOH], TM1.[BUS_AAH], TM1.[BUS_AEH], TM1.[BUS_IDT], TM1.[BUS_RUB] AS BUS_RUB FROM ([BUS000] TM1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = TM1.[BUS_RUB]) WHERE TM1.[BUS_EMP] = @BUS_EMP and TM1.[BUS_RUB] = @BUS_RUB and TM1.[BUS_COD] = @BUS_COD and TM1.[BUS_PAR] = @BUS_PAR ORDER BY TM1.[BUS_EMP], TM1.[BUS_RUB], TM1.[BUS_COD], TM1.[BUS_PAR]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O5,100,0,true,false )
             ,new CursorDef("T000O6", "SELECT [RBR_DES] AS BUS_RUD, [RBR_AMO] AS BUS_AMO FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @BUS_RUB ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O6,1,0,true,false )
             ,new CursorDef("T000O7", "SELECT [BUS_EMP], [BUS_RUB] AS BUS_RUB, [BUS_COD], [BUS_PAR] FROM [BUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O7,1,0,true,false )
             ,new CursorDef("T000O8", "SELECT TOP 1 [BUS_EMP], [BUS_RUB] AS BUS_RUB, [BUS_COD], [BUS_PAR] FROM [BUS000] WITH (NOLOCK) WHERE ( [BUS_EMP] > @BUS_EMP or [BUS_EMP] = @BUS_EMP and [BUS_RUB] > @BUS_RUB or [BUS_RUB] = @BUS_RUB and [BUS_EMP] = @BUS_EMP and [BUS_COD] > @BUS_COD or [BUS_COD] = @BUS_COD and [BUS_RUB] = @BUS_RUB and [BUS_EMP] = @BUS_EMP and [BUS_PAR] > @BUS_PAR) ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O8,1,0,true,true )
             ,new CursorDef("T000O9", "SELECT TOP 1 [BUS_EMP], [BUS_RUB] AS BUS_RUB, [BUS_COD], [BUS_PAR] FROM [BUS000] WITH (NOLOCK) WHERE ( [BUS_EMP] < @BUS_EMP or [BUS_EMP] = @BUS_EMP and [BUS_RUB] < @BUS_RUB or [BUS_RUB] = @BUS_RUB and [BUS_EMP] = @BUS_EMP and [BUS_COD] < @BUS_COD or [BUS_COD] = @BUS_COD and [BUS_RUB] = @BUS_RUB and [BUS_EMP] = @BUS_EMP and [BUS_PAR] < @BUS_PAR) ORDER BY [BUS_EMP] DESC, [BUS_RUB] DESC, [BUS_COD] DESC, [BUS_PAR] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O9,1,0,true,true )
             ,new CursorDef("T000O10", "SELECT [BUS_EMP], [BUS_COD], [BUS_PAR], [BUS_DES], [BUS_FAL], [BUS_FAD], [BUS_NCO], [BUS_COM], [BUS_ARE], [BUS_SEC], [BUS_TIP], [BUS_VUA], [BUS_VAO], [BUS_CBD], [BUS_ARD], [BUS_SED], [BUS_TID], [BUS_FBA], [BUS_MBA], [BUS_FPR], [BUS_VUT], [BUS_COE], [BUS_VOC], [BUS_VOA], [BUS_AAA], [BUS_AEA], [BUS_VAH], [BUS_VHF], [BUS_VOH], [BUS_AAH], [BUS_AEH], [BUS_IDT], [BUS_RUB] AS BUS_RUB FROM [BUS000] WITH (UPDLOCK) WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O10,1,0,true,false )
             ,new CursorDef("T000O11", "INSERT INTO [BUS000] ([BUS_EMP], [BUS_COD], [BUS_PAR], [BUS_DES], [BUS_FAL], [BUS_FAD], [BUS_NCO], [BUS_COM], [BUS_ARE], [BUS_SEC], [BUS_TIP], [BUS_VUA], [BUS_VAO], [BUS_CBD], [BUS_ARD], [BUS_SED], [BUS_TID], [BUS_FBA], [BUS_MBA], [BUS_FPR], [BUS_VUT], [BUS_COE], [BUS_VOC], [BUS_VOA], [BUS_AAA], [BUS_AEA], [BUS_VAH], [BUS_VHF], [BUS_VOH], [BUS_AAH], [BUS_AEH], [BUS_IDT], [BUS_RUB]) VALUES (@BUS_EMP, @BUS_COD, @BUS_PAR, @BUS_DES, @BUS_FAL, @BUS_FAD, @BUS_NCO, @BUS_COM, @BUS_ARE, @BUS_SEC, @BUS_TIP, @BUS_VUA, @BUS_VAO, @BUS_CBD, @BUS_ARD, @BUS_SED, @BUS_TID, @BUS_FBA, @BUS_MBA, @BUS_FPR, @BUS_VUT, @BUS_COE, @BUS_VOC, @BUS_VOA, @BUS_AAA, @BUS_AEA, @BUS_VAH, @BUS_VHF, @BUS_VOH, @BUS_AAH, @BUS_AEH, @BUS_IDT, @BUS_RUB)", GxErrorMask.GX_NOMASK,prmT000O11)
             ,new CursorDef("T000O12", "UPDATE [BUS000] SET [BUS_DES]=@BUS_DES, [BUS_FAL]=@BUS_FAL, [BUS_FAD]=@BUS_FAD, [BUS_NCO]=@BUS_NCO, [BUS_COM]=@BUS_COM, [BUS_ARE]=@BUS_ARE, [BUS_SEC]=@BUS_SEC, [BUS_TIP]=@BUS_TIP, [BUS_VUA]=@BUS_VUA, [BUS_VAO]=@BUS_VAO, [BUS_CBD]=@BUS_CBD, [BUS_ARD]=@BUS_ARD, [BUS_SED]=@BUS_SED, [BUS_TID]=@BUS_TID, [BUS_FBA]=@BUS_FBA, [BUS_MBA]=@BUS_MBA, [BUS_FPR]=@BUS_FPR, [BUS_VUT]=@BUS_VUT, [BUS_COE]=@BUS_COE, [BUS_VOC]=@BUS_VOC, [BUS_VOA]=@BUS_VOA, [BUS_AAA]=@BUS_AAA, [BUS_AEA]=@BUS_AEA, [BUS_VAH]=@BUS_VAH, [BUS_VHF]=@BUS_VHF, [BUS_VOH]=@BUS_VOH, [BUS_AAH]=@BUS_AAH, [BUS_AEH]=@BUS_AEH, [BUS_IDT]=@BUS_IDT  WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR", GxErrorMask.GX_NOMASK,prmT000O12)
             ,new CursorDef("T000O13", "DELETE FROM [BUS000]  WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR", GxErrorMask.GX_NOMASK,prmT000O13)
             ,new CursorDef("T000O14", "SELECT [RBR_DES] AS BUS_RUD, [RBR_AMO] AS BUS_AMO FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @BUS_RUB ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O14,1,0,true,false )
             ,new CursorDef("T000O15", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O15,1,0,true,true )
             ,new CursorDef("T000O16", "SELECT [BUS_EMP], [BUS_RUB] AS BUS_RUB, [BUS_COD], [BUS_PAR] FROM [BUS000] WITH (NOLOCK) ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O16,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 12) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 2) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((decimal[]) buf[12])[0] = rslt.getDecimal(13) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 20) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 30) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 30) ;
                ((String[]) buf[16])[0] = rslt.getString(17, 20) ;
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(18) ;
                ((String[]) buf[18])[0] = rslt.getString(19, 30) ;
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(20) ;
                ((short[]) buf[20])[0] = rslt.getShort(21) ;
                ((decimal[]) buf[21])[0] = rslt.getDecimal(22) ;
                ((decimal[]) buf[22])[0] = rslt.getDecimal(23) ;
                ((decimal[]) buf[23])[0] = rslt.getDecimal(24) ;
                ((decimal[]) buf[24])[0] = rslt.getDecimal(25) ;
                ((decimal[]) buf[25])[0] = rslt.getDecimal(26) ;
                ((decimal[]) buf[26])[0] = rslt.getDecimal(27) ;
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(28) ;
                ((decimal[]) buf[28])[0] = rslt.getDecimal(29) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(30) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(31) ;
                ((int[]) buf[31])[0] = rslt.getInt(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 12) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 2) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((decimal[]) buf[12])[0] = rslt.getDecimal(13) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 20) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 30) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 30) ;
                ((String[]) buf[16])[0] = rslt.getString(17, 20) ;
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(18) ;
                ((String[]) buf[18])[0] = rslt.getString(19, 30) ;
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(20) ;
                ((short[]) buf[20])[0] = rslt.getShort(21) ;
                ((decimal[]) buf[21])[0] = rslt.getDecimal(22) ;
                ((decimal[]) buf[22])[0] = rslt.getDecimal(23) ;
                ((decimal[]) buf[23])[0] = rslt.getDecimal(24) ;
                ((decimal[]) buf[24])[0] = rslt.getDecimal(25) ;
                ((decimal[]) buf[25])[0] = rslt.getDecimal(26) ;
                ((decimal[]) buf[26])[0] = rslt.getDecimal(27) ;
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(28) ;
                ((decimal[]) buf[28])[0] = rslt.getDecimal(29) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(30) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(31) ;
                ((int[]) buf[31])[0] = rslt.getInt(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 12) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 2) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 30) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((String[]) buf[13])[0] = rslt.getString(13, 1) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(13);
                ((short[]) buf[15])[0] = rslt.getShort(14) ;
                ((decimal[]) buf[16])[0] = rslt.getDecimal(15) ;
                ((String[]) buf[17])[0] = rslt.getString(16, 20) ;
                ((String[]) buf[18])[0] = rslt.getString(17, 30) ;
                ((String[]) buf[19])[0] = rslt.getString(18, 30) ;
                ((String[]) buf[20])[0] = rslt.getString(19, 20) ;
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(20) ;
                ((String[]) buf[22])[0] = rslt.getString(21, 30) ;
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(22) ;
                ((short[]) buf[24])[0] = rslt.getShort(23) ;
                ((decimal[]) buf[25])[0] = rslt.getDecimal(24) ;
                ((decimal[]) buf[26])[0] = rslt.getDecimal(25) ;
                ((decimal[]) buf[27])[0] = rslt.getDecimal(26) ;
                ((decimal[]) buf[28])[0] = rslt.getDecimal(27) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(28) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(29) ;
                ((DateTime[]) buf[31])[0] = rslt.getGXDate(30) ;
                ((decimal[]) buf[32])[0] = rslt.getDecimal(31) ;
                ((decimal[]) buf[33])[0] = rslt.getDecimal(32) ;
                ((decimal[]) buf[34])[0] = rslt.getDecimal(33) ;
                ((int[]) buf[35])[0] = rslt.getInt(34) ;
                ((short[]) buf[36])[0] = rslt.getShort(35) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 12) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 2) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((decimal[]) buf[12])[0] = rslt.getDecimal(13) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 20) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 30) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 30) ;
                ((String[]) buf[16])[0] = rslt.getString(17, 20) ;
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(18) ;
                ((String[]) buf[18])[0] = rslt.getString(19, 30) ;
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(20) ;
                ((short[]) buf[20])[0] = rslt.getShort(21) ;
                ((decimal[]) buf[21])[0] = rslt.getDecimal(22) ;
                ((decimal[]) buf[22])[0] = rslt.getDecimal(23) ;
                ((decimal[]) buf[23])[0] = rslt.getDecimal(24) ;
                ((decimal[]) buf[24])[0] = rslt.getDecimal(25) ;
                ((decimal[]) buf[25])[0] = rslt.getDecimal(26) ;
                ((decimal[]) buf[26])[0] = rslt.getDecimal(27) ;
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(28) ;
                ((decimal[]) buf[28])[0] = rslt.getDecimal(29) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(30) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(31) ;
                ((int[]) buf[31])[0] = rslt.getInt(32) ;
                ((short[]) buf[32])[0] = rslt.getShort(33) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                stmt.SetParameter(4, (String)parms[6]);
                stmt.SetParameter(5, (DateTime)parms[7]);
                stmt.SetParameter(6, (DateTime)parms[8]);
                stmt.SetParameter(7, (String)parms[9]);
                stmt.SetParameter(8, (String)parms[10]);
                stmt.SetParameter(9, (short)parms[11]);
                stmt.SetParameter(10, (short)parms[12]);
                stmt.SetParameter(11, (short)parms[13]);
                stmt.SetParameter(12, (short)parms[14]);
                stmt.SetParameter(13, (decimal)parms[15]);
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (String)parms[17]);
                stmt.SetParameter(16, (String)parms[18]);
                stmt.SetParameter(17, (String)parms[19]);
                stmt.SetParameter(18, (DateTime)parms[20]);
                stmt.SetParameter(19, (String)parms[21]);
                stmt.SetParameter(20, (DateTime)parms[22]);
                stmt.SetParameter(21, (short)parms[23]);
                stmt.SetParameter(22, (decimal)parms[24]);
                stmt.SetParameter(23, (decimal)parms[25]);
                stmt.SetParameter(24, (decimal)parms[26]);
                stmt.SetParameter(25, (decimal)parms[27]);
                stmt.SetParameter(26, (decimal)parms[28]);
                stmt.SetParameter(27, (decimal)parms[29]);
                stmt.SetParameter(28, (DateTime)parms[30]);
                stmt.SetParameter(29, (decimal)parms[31]);
                stmt.SetParameter(30, (decimal)parms[32]);
                stmt.SetParameter(31, (decimal)parms[33]);
                stmt.SetParameter(32, (int)parms[34]);
                if ( (bool)parms[35] )
                {
                   stmt.setNull( 33 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(33, (short)parms[36]);
                }
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (DateTime)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                stmt.SetParameter(17, (DateTime)parms[16]);
                stmt.SetParameter(18, (short)parms[17]);
                stmt.SetParameter(19, (decimal)parms[18]);
                stmt.SetParameter(20, (decimal)parms[19]);
                stmt.SetParameter(21, (decimal)parms[20]);
                stmt.SetParameter(22, (decimal)parms[21]);
                stmt.SetParameter(23, (decimal)parms[22]);
                stmt.SetParameter(24, (decimal)parms[23]);
                stmt.SetParameter(25, (DateTime)parms[24]);
                stmt.SetParameter(26, (decimal)parms[25]);
                stmt.SetParameter(27, (decimal)parms[26]);
                stmt.SetParameter(28, (decimal)parms[27]);
                stmt.SetParameter(29, (int)parms[28]);
                if ( (bool)parms[29] )
                {
                   stmt.setNull( 30 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(30, (String)parms[30]);
                }
                if ( (bool)parms[31] )
                {
                   stmt.setNull( 31 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(31, (short)parms[32]);
                }
                if ( (bool)parms[33] )
                {
                   stmt.setNull( 32 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(32, (short)parms[34]);
                }
                if ( (bool)parms[35] )
                {
                   stmt.setNull( 33 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(33, (short)parms[36]);
                }
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 13 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                break;
       }
    }

 }

}
