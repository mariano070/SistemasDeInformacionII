/*
               File: TSEG007
        Description: PROGRAMAS ACCEDIDOS POR SESION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:14.53
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
   public class tseg007 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A126PRG_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A6USU_COD, A116SIS_COD, A126PRG_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_10( A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO) ;
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
            A6USU_COD = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               AV9PRGCOD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRGCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9PRGCOD), 4, 0)));
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "PROGRAMAS ACCEDIDOS POR SESION", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPRG_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg007( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg007( IGxContext context )
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

      public void execute( ref String aP0_USU_COD ,
                           ref short aP1_SIS_COD ,
                           ref short aP2_PRGCOD ,
                           ref String aP3_SISTEMA ,
                           ref String aP4_USUARIO ,
                           ref String aP5_Gx_mode )
      {
         this.A6USU_COD = aP0_USU_COD;
         this.A116SIS_COD = aP1_SIS_COD;
         this.AV9PRGCOD = aP2_PRGCOD;
         this.AV7SISTEMA = aP3_SISTEMA;
         this.AV8USUARIO = aP4_USUARIO;
         this.Gx_mode = aP5_Gx_mode;
         executePrivate();
         aP0_USU_COD=this.A6USU_COD;
         aP1_SIS_COD=this.A116SIS_COD;
         aP2_PRGCOD=this.AV9PRGCOD;
         aP3_SISTEMA=this.AV7SISTEMA;
         aP4_USUARIO=this.AV8USUARIO;
         aP5_Gx_mode=this.Gx_mode;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("hmaster_seg_p", "GeneXus.Programs.hmaster_seg_p", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_1135( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1135e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1135( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'',0)\"" ;
            ClassString = "BtnFirst" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "rounded", 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"" ;
            ClassString = "BtnPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "rounded", 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"" ;
            ClassString = "BtnNext" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "rounded", 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "BtnLast" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "rounded", 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "BtnSelect" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_select_Internalname, "Seleccionar", "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "rounded", 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "gx.popup.openPrompt('"+"gx00z2.aspx"+"',["+"'"+StringUtil.RTrim( A6USU_COD)+"'"+","+"'"+StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", ""))+"'"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRS_NRO"+"'), id:'"+"PRS_NRO"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRS_ORD"+"'), id:'"+"PRS_ORD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_15_1135( true) ;
         }
         return  ;
      }

      protected void wb_table2_15_1135e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1135e( true) ;
         }
         else
         {
            wb_table1_2_1135e( false) ;
         }
      }

      protected void wb_table2_15_1135( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, edtUSU_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, edtUSU_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "CONTRASEÑA", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, 1, edtUSU_CLA_Enabled, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), "", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(45);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_126_Internalname, "", "prompt.gif", "Modern", imgprompt_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_126_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "NOMBRE FISICO", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_NFI_Internalname, StringUtil.RTrim( A289PRG_NFI), "", 8, "chr", 1, "row", 8, 1, edtPRG_NFI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")), "", 0, edtPRG_NFI_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "CONEXION DE USUARIO", "", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CNT_Internalname, StringUtil.RTrim( A290USU_CNT), "", 1, "chr", 1, "row", 1, 1, edtUSU_CNT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A290USU_CNT, "X")), "", 0, edtUSU_CNT_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "NRO DE SESION ASIGNADA", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_NRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtPRS_NRO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(65);\"", 0, edtPRS_NRO_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_118_Internalname, "", "prompt.gif", "Modern", imgprompt_118_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_118_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_INI_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_INI_Internalname, context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRS_INI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"), "", 0, edtPRS_INI_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            GxWebStd.gx_bitmap( context, edtPRS_INI_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRS_INI_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG007.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, 1, 1, 0, "ULTIMO OBJETO", "", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UOB_Internalname, StringUtil.RTrim( A404PRS_UOB), "", 20, "chr", 1, "row", 20, 1, edtPRS_UOB_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A404PRS_UOB, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRS_UOB_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, 1, 1, 0, "DESCRIPCION ULTIMO OBJETO", "", "", "", 0, lblTextblock13_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UDE_Internalname, StringUtil.RTrim( A405PRS_UDE), "", 30, "chr", 1, "row", 30, 1, edtPRS_UDE_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A405PRS_UDE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRS_UDE_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, 1, 1, 0, "ULTIMO LINK", "", "", "", 0, lblTextblock14_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPRS_ULNK_Internalname, A406PRS_ULNK, 1, edtPRS_ULNK_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "300", "", -1, 0, "", "", true, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, 1, 1, 0, "MOMENTO CADUCIDAD SESION", "", "", "", 0, lblTextblock15_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_CAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_CAD_Internalname, context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRS_CAD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A165PRS_CAD, "99/99/99 99:99"), "", 0, edtPRS_CAD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            GxWebStd.gx_bitmap( context, edtPRS_CAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRS_CAD_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG007.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, 1, 1, 0, "ORDEN DE LLAMADOS", "", "", "", 0, lblTextblock16_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_ORD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtPRS_ORD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A407PRS_ORD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(95);\"", 0, edtPRS_ORD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, 1, 1, 0, "DESCRIPCION PROGRAMA", "", "", "", 0, lblTextblock17_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_DES_Internalname, StringUtil.RTrim( A408PRS_DES), "", 30, "chr", 1, "row", 30, 1, edtPRS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A408PRS_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(101);\"", 0, edtPRS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock18_Internalname, 1, 1, 0, "LINK PROGRAMA", "", "", "", 0, lblTextblock18_Jsonclick, "", StyleString, ClassString, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPRS_LINK_Internalname, A409PRS_LINK, 1, edtPRS_LINK_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "300", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(106);\"", -1, 0, "", "", true, "HLP_TSEG007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_15_1135e( true) ;
         }
         else
         {
            wb_table2_15_1135e( false) ;
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
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRG_COD_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A126PRG_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               else
               {
                  A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               A290USU_CNT = cgiGet( edtUSU_CNT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRS_NRO_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRS_NRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRS_NRO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A118PRS_NRO = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               }
               else
               {
                  A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               }
               A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               A404PRS_UOB = cgiGet( edtPRS_UOB_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
               A405PRS_UDE = cgiGet( edtPRS_UDE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
               A406PRS_ULNK = cgiGet( edtPRS_ULNK_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
               A165PRS_CAD = context.localUtil.CToT( cgiGet( edtPRS_CAD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRS_ORD_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtPRS_ORD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRS_ORD_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRS_ORD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRS_ORD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A407PRS_ORD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               }
               else
               {
                  A407PRS_ORD = (short)(context.localUtil.CToN( cgiGet( edtPRS_ORD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               }
               A408PRS_DES = cgiGet( edtPRS_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
               A409PRS_LINK = cgiGet( edtPRS_LINK_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409PRS_LINK", A409PRS_LINK);
               /* Read saved values. */
               Z6USU_COD = cgiGet( "Z6USU_COD") ;
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( "Z118PRS_NRO"), ",", ".")) ;
               Z407PRS_ORD = (short)(context.localUtil.CToN( cgiGet( "Z407PRS_ORD"), ",", ".")) ;
               Z408PRS_DES = cgiGet( "Z408PRS_DES") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV9PRGCOD = (short)(context.localUtil.CToN( cgiGet( "vPRGCOD"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
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
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A118PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                  A407PRS_ORD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
                  getEqualNoModal( ) ;
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A126PRG_COD = AV9PRGCOD ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
                     {
                        A126PRG_COD = AV9PRGCOD ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                     }
                  }
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  standaloneModal( ) ;
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GET") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_get( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_Check( ) ;
                           /* No code required for Help button. It is implemented at the Browser level. */
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1135( ) ;
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
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
            edtUSU_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_DES_Enabled), 5, 0)));
            edtUSU_CLA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CLA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Enabled), 5, 0)));
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
            edtSIS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            edtPRG_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
            edtPRG_NFI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_NFI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_NFI_Enabled), 5, 0)));
            edtUSU_CNT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CNT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CNT_Enabled), 5, 0)));
            edtPRS_NRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Enabled), 5, 0)));
            edtPRS_INI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_INI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_INI_Enabled), 5, 0)));
            edtPRS_UOB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_UOB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_UOB_Enabled), 5, 0)));
            edtPRS_UDE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_UDE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_UDE_Enabled), 5, 0)));
            edtPRS_ULNK_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_ULNK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_ULNK_Enabled), 5, 0)));
            edtPRS_CAD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_CAD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_CAD_Enabled), 5, 0)));
            edtPRS_ORD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_ORD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_ORD_Enabled), 5, 0)));
            edtPRS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_DES_Enabled), 5, 0)));
            edtPRS_LINK_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_LINK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_LINK_Enabled), 5, 0)));
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

      protected void CONFIRM_110( )
      {
         BeforeValidate1135( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1135( ) ;
            }
            else
            {
               CheckExtendedTable1135( ) ;
               if ( AnyError == 0 )
               {
                  ZM1135( 6) ;
                  ZM1135( 7) ;
                  ZM1135( 8) ;
                  ZM1135( 9) ;
                  ZM1135( 10) ;
               }
               CloseExtendedTableCursors1135( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues110( ) ;
         }
      }

      protected void ResetCaption110( )
      {
      }

      protected void ZM1135( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z408PRS_DES = T00113_A408PRS_DES[0] ;
            }
            else
            {
               Z408PRS_DES = A408PRS_DES ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z407PRS_ORD = A407PRS_ORD ;
            Z408PRS_DES = A408PRS_DES ;
            Z409PRS_LINK = A409PRS_LINK ;
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z118PRS_NRO = A118PRS_NRO ;
            Z7USU_DES = A7USU_DES ;
            Z155USU_CLA = A155USU_CLA ;
            Z259SIS_DES = A259SIS_DES ;
            Z127PRG_DES = A127PRG_DES ;
            Z289PRG_NFI = A289PRG_NFI ;
            Z290USU_CNT = A290USU_CNT ;
            Z166PRS_INI = A166PRS_INI ;
            Z404PRS_UOB = A404PRS_UOB ;
            Z405PRS_UDE = A405PRS_UDE ;
            Z406PRS_ULNK = A406PRS_ULNK ;
            Z165PRS_CAD = A165PRS_CAD ;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         /* Using cursor T00114 */
         pr_default.execute(2, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T00114_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00114_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         pr_default.close(2);
         /* Using cursor T00115 */
         pr_default.execute(3, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T00115_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(3);
         imgprompt_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00l2.aspx"+"',["+"'"+StringUtil.RTrim( A6USU_COD)+"'"+","+"'"+StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", ""))+"'"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_118_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y3.aspx"+"',["+"'"+StringUtil.RTrim( A6USU_COD)+"'"+","+"'"+StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", ""))+"'"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:false,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRS_NRO"+"'), id:'"+"PRS_NRO"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         else
         {
            edtPRG_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            bttBtn_get_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_get_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_check_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            A126PRG_COD = AV9PRGCOD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A126PRG_COD = AV9PRGCOD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00116 */
            pr_default.execute(4, new Object[] {A126PRG_COD});
            A127PRG_DES = T00116_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00116_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            pr_default.close(4);
            /* Using cursor T00117 */
            pr_default.execute(5, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            A290USU_CNT = T00117_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            pr_default.close(5);
         }
      }

      protected void Load1135( )
      {
         /* Using cursor T00119 */
         pr_default.execute(7, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound35 = 1 ;
            A7USU_DES = T00119_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00119_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A259SIS_DES = T00119_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A127PRG_DES = T00119_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00119_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            A290USU_CNT = T00119_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            A166PRS_INI = T00119_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T00119_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A405PRS_UDE = T00119_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T00119_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            A165PRS_CAD = T00119_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            A408PRS_DES = T00119_A408PRS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
            A409PRS_LINK = T00119_A409PRS_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409PRS_LINK", A409PRS_LINK);
            ZM1135( -5) ;
         }
         pr_default.close(7);
         OnLoadActions1135( ) ;
      }

      protected void OnLoadActions1135( )
      {
      }

      protected void CheckExtendedTable1135( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00116 */
         pr_default.execute(4, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T00116_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00116_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         }
         pr_default.close(4);
         /* Using cursor T00117 */
         pr_default.execute(5, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T00117_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         }
         pr_default.close(5);
         if ( (0==A126PRG_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00118 */
         pr_default.execute(6, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'SESIONES POR USUARIO'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A166PRS_INI = T00118_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T00118_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A405PRS_UDE = T00118_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T00118_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            A165PRS_CAD = T00118_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
         }
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors1135( )
      {
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A126PRG_COD )
      {
         /* Using cursor T001110 */
         pr_default.execute(8, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T001110_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T001110_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127PRG_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A289PRG_NFI))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void gxLoad_9( String A6USU_COD ,
                               short A116SIS_COD ,
                               short A126PRG_COD )
      {
         /* Using cursor T001111 */
         pr_default.execute(9, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T001111_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A290USU_CNT))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void gxLoad_10( String A6USU_COD ,
                                short A116SIS_COD ,
                                short A126PRG_COD ,
                                int A118PRS_NRO )
      {
         /* Using cursor T001112 */
         pr_default.execute(10, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'SESIONES POR USUARIO'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A166PRS_INI = T001112_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T001112_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A405PRS_UDE = T001112_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T001112_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            A165PRS_CAD = T001112_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A404PRS_UOB))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A405PRS_UDE))+"\""+","+"\""+GXUtil.EncodeJSConstant( A406PRS_ULNK)+"\""+","+"\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void GetKey1135( )
      {
         /* Using cursor T001113 */
         pr_default.execute(11, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound35 = 1 ;
         }
         else
         {
            RcdFound35 = 0 ;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00113 */
         pr_default.execute(1, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
         if ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(T00113_A6USU_COD[0], A6USU_COD) == 0 ) && ( T00113_A116SIS_COD[0] == A116SIS_COD ) )
         {
            ZM1135( 5) ;
            RcdFound35 = 1 ;
            A407PRS_ORD = T00113_A407PRS_ORD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
            A408PRS_DES = T00113_A408PRS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
            A409PRS_LINK = T00113_A409PRS_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409PRS_LINK", A409PRS_LINK);
            A126PRG_COD = T00113_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = T00113_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z118PRS_NRO = A118PRS_NRO ;
            Z407PRS_ORD = A407PRS_ORD ;
            sMode35 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1135( ) ;
            Gx_mode = sMode35 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound35 = 0 ;
            InitializeNonKey1135( ) ;
            sMode35 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode35 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1135( ) ;
         if ( RcdFound35 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound35 = 0 ;
         /* Using cursor T001114 */
         pr_default.execute(12, new Object[] {A126PRG_COD, A118PRS_NRO, A407PRS_ORD, A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T001114_A126PRG_COD[0] < A126PRG_COD ) || ( T001114_A126PRG_COD[0] == A126PRG_COD ) && ( T001114_A118PRS_NRO[0] < A118PRS_NRO ) || ( T001114_A118PRS_NRO[0] == A118PRS_NRO ) && ( T001114_A126PRG_COD[0] == A126PRG_COD ) && ( T001114_A407PRS_ORD[0] < A407PRS_ORD ) ) && ( StringUtil.StrCmp(T001114_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001114_A116SIS_COD[0] == A116SIS_COD ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T001114_A126PRG_COD[0] > A126PRG_COD ) || ( T001114_A126PRG_COD[0] == A126PRG_COD ) && ( T001114_A118PRS_NRO[0] > A118PRS_NRO ) || ( T001114_A118PRS_NRO[0] == A118PRS_NRO ) && ( T001114_A126PRG_COD[0] == A126PRG_COD ) && ( T001114_A407PRS_ORD[0] > A407PRS_ORD ) ) && ( StringUtil.StrCmp(T001114_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001114_A116SIS_COD[0] == A116SIS_COD ) )
            {
               A126PRG_COD = T001114_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = T001114_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A407PRS_ORD = T001114_A407PRS_ORD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               RcdFound35 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound35 = 0 ;
         /* Using cursor T001115 */
         pr_default.execute(13, new Object[] {A126PRG_COD, A118PRS_NRO, A407PRS_ORD, A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T001115_A126PRG_COD[0] > A126PRG_COD ) || ( T001115_A126PRG_COD[0] == A126PRG_COD ) && ( T001115_A118PRS_NRO[0] > A118PRS_NRO ) || ( T001115_A118PRS_NRO[0] == A118PRS_NRO ) && ( T001115_A126PRG_COD[0] == A126PRG_COD ) && ( T001115_A407PRS_ORD[0] > A407PRS_ORD ) ) && ( StringUtil.StrCmp(T001115_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001115_A116SIS_COD[0] == A116SIS_COD ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T001115_A126PRG_COD[0] < A126PRG_COD ) || ( T001115_A126PRG_COD[0] == A126PRG_COD ) && ( T001115_A118PRS_NRO[0] < A118PRS_NRO ) || ( T001115_A118PRS_NRO[0] == A118PRS_NRO ) && ( T001115_A126PRG_COD[0] == A126PRG_COD ) && ( T001115_A407PRS_ORD[0] < A407PRS_ORD ) ) && ( StringUtil.StrCmp(T001115_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001115_A116SIS_COD[0] == A116SIS_COD ) )
            {
               A126PRG_COD = T001115_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = T001115_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A407PRS_ORD = T001115_A407PRS_ORD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               RcdFound35 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1135( ) ;
         if ( RcdFound35 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) || ( A407PRS_ORD != Z407PRS_ORD ) )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = Z118PRS_NRO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A407PRS_ORD = Z407PRS_ORD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update1135( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) || ( A407PRS_ORD != Z407PRS_ORD ) )
            {
               /* Insert record */
               Insert1135( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert1135( ) ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) || ( A407PRS_ORD != Z407PRS_ORD ) )
         {
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = Z118PRS_NRO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            A407PRS_ORD = Z407PRS_ORD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey1135( ) ;
         if ( RcdFound35 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) || ( A407PRS_ORD != Z407PRS_ORD ) )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = Z118PRS_NRO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A407PRS_ORD = Z407PRS_ORD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) || ( A407PRS_ORD != Z407PRS_ORD ) )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(13);
         pr_default.close(12);
         context.RollbackDataStores("TSEG007");
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_110( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
         }
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1135( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1135( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1135( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound35 != 0 )
            {
               ScanNext1135( ) ;
            }
         }
         GX_FocusControl = edtPRS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1135( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1135( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001116 */
            pr_default.execute(14, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
            if ( (pr_default.getStatus(14) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG007"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(14) == 101) || ( StringUtil.StrCmp(Z408PRS_DES, T001116_A408PRS_DES[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG007"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1135( )
      {
         BeforeValidate1135( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1135( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1135( 0) ;
            CheckOptimisticConcurrency1135( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1135( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1135( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001117 */
                     pr_default.execute(15, new Object[] {A407PRS_ORD, A408PRS_DES, A409PRS_LINK, A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 1) )
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
                           ResetCaption110( ) ;
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
               Load1135( ) ;
            }
            EndLevel1135( ) ;
         }
         CloseExtendedTableCursors1135( ) ;
      }

      protected void Update1135( )
      {
         BeforeValidate1135( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1135( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1135( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1135( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1135( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001118 */
                     pr_default.execute(16, new Object[] {A408PRS_DES, A409PRS_LINK, A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
                     pr_default.close(16);
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG007"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1135( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption110( ) ;
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
            EndLevel1135( ) ;
         }
         CloseExtendedTableCursors1135( ) ;
      }

      protected void DeferredUpdate1135( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1135( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1135( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1135( ) ;
            AfterConfirm1135( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1135( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001119 */
                  pr_default.execute(17, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A407PRS_ORD});
                  pr_default.close(17);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound35 == 0 )
                        {
                           InitAll1135( ) ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption110( ) ;
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
         sMode35 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1135( ) ;
         Gx_mode = sMode35 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1135( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001120 */
            pr_default.execute(18, new Object[] {A126PRG_COD});
            A127PRG_DES = T001120_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T001120_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            pr_default.close(18);
            /* Using cursor T001121 */
            pr_default.execute(19, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            A290USU_CNT = T001121_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            pr_default.close(19);
            /* Using cursor T001122 */
            pr_default.execute(20, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
            A166PRS_INI = T001122_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T001122_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A405PRS_UDE = T001122_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T001122_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            A165PRS_CAD = T001122_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            pr_default.close(20);
         }
      }

      protected void EndLevel1135( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1135( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            context.CommitDataStores("TSEG007");
            if ( AnyError == 0 )
            {
               ConfirmValues110( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            context.RollbackDataStores("TSEG007");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1135( )
      {
         /* Using cursor T001123 */
         pr_default.execute(21, new Object[] {A6USU_COD, A116SIS_COD});
         RcdFound35 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound35 = 1 ;
            A126PRG_COD = T001123_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = T001123_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            A407PRS_ORD = T001123_A407PRS_ORD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1135( )
      {
         pr_default.readNext(21);
         RcdFound35 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound35 = 1 ;
            A126PRG_COD = T001123_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = T001123_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            A407PRS_ORD = T001123_A407PRS_ORD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
         }
      }

      protected void ScanEnd1135( )
      {
      }

      protected void AfterConfirm1135( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1135( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1135( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1135( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1135( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1135( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues110( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +AV9PRGCOD) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z6USU_COD", StringUtil.RTrim( Z6USU_COD));
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z118PRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z118PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z407PRS_ORD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z407PRS_ORD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z408PRS_DES", StringUtil.RTrim( Z408PRS_DES));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vPRGCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9PRGCOD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return "TSEG007" ;
      }

      public override String GetPgmdesc( )
      {
         return "PROGRAMAS ACCEDIDOS POR SESION" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +AV9PRGCOD) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) ;
      }

      protected void InitializeNonKey1135( )
      {
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A289PRG_NFI = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         A290USU_CNT = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
         A404PRS_UOB = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
         A405PRS_UDE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
         A406PRS_ULNK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
         A408PRS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
         A409PRS_LINK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409PRS_LINK", A409PRS_LINK);
      }

      protected void InitAll1135( )
      {
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A118PRS_NRO = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         A407PRS_ORD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
         InitializeNonKey1135( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1181696");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg007.js", "?1181696");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_select_Internalname = "BTN_SELECT" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtUSU_CLA_Internalname = "USU_CLA" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtPRG_NFI_Internalname = "PRG_NFI" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtUSU_CNT_Internalname = "USU_CNT" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtPRS_NRO_Internalname = "PRS_NRO" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtPRS_INI_Internalname = "PRS_INI" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtPRS_UOB_Internalname = "PRS_UOB" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtPRS_UDE_Internalname = "PRS_UDE" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtPRS_ULNK_Internalname = "PRS_ULNK" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtPRS_CAD_Internalname = "PRS_CAD" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtPRS_ORD_Internalname = "PRS_ORD" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock17_Internalname = "TEXTBLOCK17" ;
         edtPRS_DES_Internalname = "PRS_DES" ;
         lblTextblock18_Internalname = "TEXTBLOCK18" ;
         edtPRS_LINK_Internalname = "PRS_LINK" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_126_Internalname = "PROMPT_126" ;
         imgprompt_118_Internalname = "PROMPT_118" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "PROGRAMAS ACCEDIDOS POR SESION" ;
         edtPRS_LINK_Enabled = 1 ;
         edtPRS_DES_Jsonclick = "" ;
         edtPRS_DES_Enabled = 1 ;
         bttBtn_get_Enabled = 1 ;
         bttBtn_get_Visible = 1 ;
         edtPRS_ORD_Jsonclick = "" ;
         edtPRS_ORD_Enabled = 1 ;
         edtPRS_CAD_Jsonclick = "" ;
         edtPRS_CAD_Enabled = 0 ;
         edtPRS_ULNK_Enabled = 0 ;
         edtPRS_UDE_Jsonclick = "" ;
         edtPRS_UDE_Enabled = 0 ;
         edtPRS_UOB_Jsonclick = "" ;
         edtPRS_UOB_Enabled = 0 ;
         edtPRS_INI_Jsonclick = "" ;
         edtPRS_INI_Enabled = 0 ;
         imgprompt_118_Visible = 1 ;
         imgprompt_118_Link = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtPRS_NRO_Enabled = 1 ;
         edtUSU_CNT_Jsonclick = "" ;
         edtUSU_CNT_Enabled = 0 ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_NFI_Enabled = 0 ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_DES_Enabled = 0 ;
         imgprompt_126_Visible = 1 ;
         imgprompt_126_Link = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Enabled = 1 ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 0 ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Enabled = 0 ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_CLA_Enabled = 0 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_DES_Enabled = 0 ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Enabled = 0 ;
         bttBtn_help_Visible = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_check_Enabled = 1 ;
         bttBtn_check_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_select_Visible = 1 ;
         bttBtn_last_Visible = 1 ;
         bttBtn_next_Visible = 1 ;
         bttBtn_previous_Visible = 1 ;
         bttBtn_first_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Prg_cod( short GX_Parm1 ,
                                 String GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 ,
                                 String GX_Parm5 ,
                                 String GX_Parm6 )
      {
         A126PRG_COD = GX_Parm1 ;
         A6USU_COD = GX_Parm2 ;
         A116SIS_COD = GX_Parm3 ;
         A127PRG_DES = GX_Parm4 ;
         A289PRG_NFI = GX_Parm5 ;
         A290USU_CNT = GX_Parm6 ;
         /* Using cursor T001120 */
         pr_default.execute(18, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T001120_A127PRG_DES[0] ;
            A289PRG_NFI = T001120_A289PRG_NFI[0] ;
         }
         pr_default.close(18);
         /* Using cursor T001121 */
         pr_default.execute(19, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T001121_A290USU_CNT[0] ;
         }
         pr_default.close(19);
         if ( (0==A126PRG_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127PRG_DES = "" ;
            A289PRG_NFI = "" ;
            A290USU_CNT = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A289PRG_NFI)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A290USU_CNT)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Prs_nro( String GX_Parm1 ,
                                 short GX_Parm2 ,
                                 short GX_Parm3 ,
                                 int GX_Parm4 ,
                                 DateTime GX_Parm5 ,
                                 String GX_Parm6 ,
                                 String GX_Parm7 ,
                                 String GX_Parm8 ,
                                 DateTime GX_Parm9 )
      {
         A6USU_COD = GX_Parm1 ;
         A116SIS_COD = GX_Parm2 ;
         A126PRG_COD = GX_Parm3 ;
         A118PRS_NRO = GX_Parm4 ;
         A166PRS_INI = GX_Parm5 ;
         A404PRS_UOB = GX_Parm6 ;
         A405PRS_UDE = GX_Parm7 ;
         A406PRS_ULNK = GX_Parm8 ;
         A165PRS_CAD = GX_Parm9 ;
         /* Using cursor T001122 */
         pr_default.execute(20, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No existe 'SESIONES POR USUARIO'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A166PRS_INI = T001122_A166PRS_INI[0] ;
            A404PRS_UOB = T001122_A404PRS_UOB[0] ;
            A405PRS_UDE = T001122_A405PRS_UDE[0] ;
            A406PRS_ULNK = T001122_A406PRS_ULNK[0] ;
            A165PRS_CAD = T001122_A165PRS_CAD[0] ;
         }
         pr_default.close(20);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A166PRS_INI = (DateTime)(DateTime.MinValue) ;
            A404PRS_UOB = "" ;
            A405PRS_UDE = "" ;
            A406PRS_ULNK = "" ;
            A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A166PRS_INI, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A404PRS_UOB)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A405PRS_UDE)));
         isValidOutput.Add((Object)(A406PRS_ULNK));
         isValidOutput.Add((Object)(context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99")));
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
         pr_default.close(21);
         pr_default.close(13);
         pr_default.close(12);
         pr_default.close(19);
         pr_default.close(20);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOA6USU_COD = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         wcpOGx_mode = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_select_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_help_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         A7USU_DES = "" ;
         lblTextblock3_Jsonclick = "" ;
         A155USU_CLA = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         A259SIS_DES = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblock8_Jsonclick = "" ;
         A289PRG_NFI = "" ;
         lblTextblock9_Jsonclick = "" ;
         A290USU_CNT = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         lblTextblock12_Jsonclick = "" ;
         A404PRS_UOB = "" ;
         lblTextblock13_Jsonclick = "" ;
         A405PRS_UDE = "" ;
         lblTextblock14_Jsonclick = "" ;
         A406PRS_ULNK = "" ;
         lblTextblock15_Jsonclick = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         lblTextblock16_Jsonclick = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock17_Jsonclick = "" ;
         A408PRS_DES = "" ;
         lblTextblock18_Jsonclick = "" ;
         A409PRS_LINK = "" ;
         Z6USU_COD = "" ;
         Z408PRS_DES = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z409PRS_LINK = "" ;
         Z7USU_DES = "" ;
         Z155USU_CLA = "" ;
         Z259SIS_DES = "" ;
         Z127PRG_DES = "" ;
         Z289PRG_NFI = "" ;
         Z290USU_CNT = "" ;
         Z166PRS_INI = (DateTime)(DateTime.MinValue) ;
         Z404PRS_UOB = "" ;
         Z405PRS_UDE = "" ;
         Z406PRS_ULNK = "" ;
         Z165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         T00114_A7USU_DES = new String[] {""} ;
         T00114_A155USU_CLA = new String[] {""} ;
         T00115_A259SIS_DES = new String[] {""} ;
         T00116_A127PRG_DES = new String[] {""} ;
         T00116_A289PRG_NFI = new String[] {""} ;
         T00117_A290USU_CNT = new String[] {""} ;
         T00119_A407PRS_ORD = new short[1] ;
         T00119_A7USU_DES = new String[] {""} ;
         T00119_A155USU_CLA = new String[] {""} ;
         T00119_A259SIS_DES = new String[] {""} ;
         T00119_A127PRG_DES = new String[] {""} ;
         T00119_A289PRG_NFI = new String[] {""} ;
         T00119_A290USU_CNT = new String[] {""} ;
         T00119_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T00119_A404PRS_UOB = new String[] {""} ;
         T00119_A405PRS_UDE = new String[] {""} ;
         T00119_A406PRS_ULNK = new String[] {""} ;
         T00119_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T00119_A408PRS_DES = new String[] {""} ;
         T00119_A409PRS_LINK = new String[] {""} ;
         T00119_A6USU_COD = new String[] {""} ;
         T00119_A116SIS_COD = new short[1] ;
         T00119_A126PRG_COD = new short[1] ;
         T00119_A118PRS_NRO = new int[1] ;
         T00118_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T00118_A404PRS_UOB = new String[] {""} ;
         T00118_A405PRS_UDE = new String[] {""} ;
         T00118_A406PRS_ULNK = new String[] {""} ;
         T00118_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T001110_A127PRG_DES = new String[] {""} ;
         T001110_A289PRG_NFI = new String[] {""} ;
         T001111_A290USU_CNT = new String[] {""} ;
         T001112_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T001112_A404PRS_UOB = new String[] {""} ;
         T001112_A405PRS_UDE = new String[] {""} ;
         T001112_A406PRS_ULNK = new String[] {""} ;
         T001112_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T001113_A6USU_COD = new String[] {""} ;
         T001113_A116SIS_COD = new short[1] ;
         T001113_A126PRG_COD = new short[1] ;
         T001113_A118PRS_NRO = new int[1] ;
         T001113_A407PRS_ORD = new short[1] ;
         T00113_A407PRS_ORD = new short[1] ;
         T00113_A408PRS_DES = new String[] {""} ;
         T00113_A409PRS_LINK = new String[] {""} ;
         T00113_A6USU_COD = new String[] {""} ;
         T00113_A116SIS_COD = new short[1] ;
         T00113_A126PRG_COD = new short[1] ;
         T00113_A118PRS_NRO = new int[1] ;
         sMode35 = "" ;
         T001114_A6USU_COD = new String[] {""} ;
         T001114_A116SIS_COD = new short[1] ;
         T001114_A126PRG_COD = new short[1] ;
         T001114_A118PRS_NRO = new int[1] ;
         T001114_A407PRS_ORD = new short[1] ;
         T001115_A6USU_COD = new String[] {""} ;
         T001115_A116SIS_COD = new short[1] ;
         T001115_A126PRG_COD = new short[1] ;
         T001115_A118PRS_NRO = new int[1] ;
         T001115_A407PRS_ORD = new short[1] ;
         T001116_A407PRS_ORD = new short[1] ;
         T001116_A408PRS_DES = new String[] {""} ;
         T001116_A409PRS_LINK = new String[] {""} ;
         T001116_A6USU_COD = new String[] {""} ;
         T001116_A116SIS_COD = new short[1] ;
         T001116_A126PRG_COD = new short[1] ;
         T001116_A118PRS_NRO = new int[1] ;
         T001120_A127PRG_DES = new String[] {""} ;
         T001120_A289PRG_NFI = new String[] {""} ;
         T001121_A290USU_CNT = new String[] {""} ;
         T001122_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T001122_A404PRS_UOB = new String[] {""} ;
         T001122_A405PRS_UDE = new String[] {""} ;
         T001122_A406PRS_ULNK = new String[] {""} ;
         T001122_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T001123_A6USU_COD = new String[] {""} ;
         T001123_A116SIS_COD = new short[1] ;
         T001123_A126PRG_COD = new short[1] ;
         T001123_A118PRS_NRO = new int[1] ;
         T001123_A407PRS_ORD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg007__default(),
            new Object[][] {
                new Object[] {
               T00112_A407PRS_ORD, T00112_A408PRS_DES, T00112_A409PRS_LINK, T00112_A6USU_COD, T00112_A116SIS_COD, T00112_A126PRG_COD, T00112_A118PRS_NRO
               }
               , new Object[] {
               T00113_A407PRS_ORD, T00113_A408PRS_DES, T00113_A409PRS_LINK, T00113_A6USU_COD, T00113_A116SIS_COD, T00113_A126PRG_COD, T00113_A118PRS_NRO
               }
               , new Object[] {
               T00114_A7USU_DES, T00114_A155USU_CLA
               }
               , new Object[] {
               T00115_A259SIS_DES
               }
               , new Object[] {
               T00116_A127PRG_DES, T00116_A289PRG_NFI
               }
               , new Object[] {
               T00117_A290USU_CNT
               }
               , new Object[] {
               T00118_A166PRS_INI, T00118_A404PRS_UOB, T00118_A405PRS_UDE, T00118_A406PRS_ULNK, T00118_A165PRS_CAD
               }
               , new Object[] {
               T00119_A407PRS_ORD, T00119_A7USU_DES, T00119_A155USU_CLA, T00119_A259SIS_DES, T00119_A127PRG_DES, T00119_A289PRG_NFI, T00119_A290USU_CNT, T00119_A166PRS_INI, T00119_A404PRS_UOB, T00119_A405PRS_UDE,
               T00119_A406PRS_ULNK, T00119_A165PRS_CAD, T00119_A408PRS_DES, T00119_A409PRS_LINK, T00119_A6USU_COD, T00119_A116SIS_COD, T00119_A126PRG_COD, T00119_A118PRS_NRO
               }
               , new Object[] {
               T001110_A127PRG_DES, T001110_A289PRG_NFI
               }
               , new Object[] {
               T001111_A290USU_CNT
               }
               , new Object[] {
               T001112_A166PRS_INI, T001112_A404PRS_UOB, T001112_A405PRS_UDE, T001112_A406PRS_ULNK, T001112_A165PRS_CAD
               }
               , new Object[] {
               T001113_A6USU_COD, T001113_A116SIS_COD, T001113_A126PRG_COD, T001113_A118PRS_NRO, T001113_A407PRS_ORD
               }
               , new Object[] {
               T001114_A6USU_COD, T001114_A116SIS_COD, T001114_A126PRG_COD, T001114_A118PRS_NRO, T001114_A407PRS_ORD
               }
               , new Object[] {
               T001115_A6USU_COD, T001115_A116SIS_COD, T001115_A126PRG_COD, T001115_A118PRS_NRO, T001115_A407PRS_ORD
               }
               , new Object[] {
               T001116_A407PRS_ORD, T001116_A408PRS_DES, T001116_A409PRS_LINK, T001116_A6USU_COD, T001116_A116SIS_COD, T001116_A126PRG_COD, T001116_A118PRS_NRO
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001120_A127PRG_DES, T001120_A289PRG_NFI
               }
               , new Object[] {
               T001121_A290USU_CNT
               }
               , new Object[] {
               T001122_A166PRS_INI, T001122_A404PRS_UOB, T001122_A405PRS_UDE, T001122_A406PRS_ULNK, T001122_A165PRS_CAD
               }
               , new Object[] {
               T001123_A6USU_COD, T001123_A116SIS_COD, T001123_A126PRG_COD, T001123_A118PRS_NRO, T001123_A407PRS_ORD
               }
            }
         );
         Z116SIS_COD = 0 ;
         Z6USU_COD = "" ;
      }

      private short wcpOA116SIS_COD ;
      private short wcpOAV9PRGCOD ;
      private short GxWebError ;
      private short A126PRG_COD ;
      private short A116SIS_COD ;
      private short AV9PRGCOD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A407PRS_ORD ;
      private short Z116SIS_COD ;
      private short Z126PRG_COD ;
      private short Z407PRS_ORD ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound35 ;
      private short gxajaxcallmode ;
      private int A118PRS_NRO ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_help_Visible ;
      private int edtUSU_COD_Enabled ;
      private int edtUSU_DES_Enabled ;
      private int edtUSU_CLA_Enabled ;
      private int edtSIS_COD_Enabled ;
      private int edtSIS_DES_Enabled ;
      private int edtPRG_COD_Enabled ;
      private int imgprompt_126_Visible ;
      private int edtPRG_DES_Enabled ;
      private int edtPRG_NFI_Enabled ;
      private int edtUSU_CNT_Enabled ;
      private int edtPRS_NRO_Enabled ;
      private int imgprompt_118_Visible ;
      private int edtPRS_INI_Enabled ;
      private int edtPRS_UOB_Enabled ;
      private int edtPRS_UDE_Enabled ;
      private int edtPRS_ULNK_Enabled ;
      private int edtPRS_CAD_Enabled ;
      private int edtPRS_ORD_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtPRS_DES_Enabled ;
      private int edtPRS_LINK_Enabled ;
      private int Z118PRS_NRO ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOA6USU_COD ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A6USU_COD ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String Gx_mode ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPRG_COD_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_COD_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtUSU_DES_Internalname ;
      private String A7USU_DES ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtUSU_CLA_Internalname ;
      private String A155USU_CLA ;
      private String edtUSU_CLA_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_COD_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String imgprompt_126_Internalname ;
      private String imgprompt_126_Link ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtPRG_NFI_Internalname ;
      private String A289PRG_NFI ;
      private String edtPRG_NFI_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtUSU_CNT_Internalname ;
      private String A290USU_CNT ;
      private String edtUSU_CNT_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_NRO_Jsonclick ;
      private String imgprompt_118_Internalname ;
      private String imgprompt_118_Link ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtPRS_INI_Internalname ;
      private String edtPRS_INI_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtPRS_UOB_Internalname ;
      private String A404PRS_UOB ;
      private String edtPRS_UOB_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtPRS_UDE_Internalname ;
      private String A405PRS_UDE ;
      private String edtPRS_UDE_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtPRS_ULNK_Internalname ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtPRS_CAD_Internalname ;
      private String edtPRS_CAD_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtPRS_ORD_Internalname ;
      private String edtPRS_ORD_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String edtPRS_DES_Internalname ;
      private String A408PRS_DES ;
      private String edtPRS_DES_Jsonclick ;
      private String lblTextblock18_Internalname ;
      private String lblTextblock18_Jsonclick ;
      private String edtPRS_LINK_Internalname ;
      private String Z6USU_COD ;
      private String Z408PRS_DES ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z7USU_DES ;
      private String Z155USU_CLA ;
      private String Z259SIS_DES ;
      private String Z127PRG_DES ;
      private String Z289PRG_NFI ;
      private String Z290USU_CNT ;
      private String Z404PRS_UOB ;
      private String Z405PRS_UDE ;
      private String sMode35 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private DateTime A166PRS_INI ;
      private DateTime A165PRS_CAD ;
      private DateTime Z166PRS_INI ;
      private DateTime Z165PRS_CAD ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A406PRS_ULNK ;
      private String A409PRS_LINK ;
      private String Z409PRS_LINK ;
      private String Z406PRS_ULNK ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private short aP1_SIS_COD ;
      private short aP2_PRGCOD ;
      private String aP3_SISTEMA ;
      private String aP4_USUARIO ;
      private String aP5_Gx_mode ;
      private IDataStoreProvider pr_default ;
      private String[] T00114_A7USU_DES ;
      private String[] T00114_A155USU_CLA ;
      private String[] T00115_A259SIS_DES ;
      private String[] T00116_A127PRG_DES ;
      private String[] T00116_A289PRG_NFI ;
      private String[] T00117_A290USU_CNT ;
      private short[] T00119_A407PRS_ORD ;
      private String[] T00119_A7USU_DES ;
      private String[] T00119_A155USU_CLA ;
      private String[] T00119_A259SIS_DES ;
      private String[] T00119_A127PRG_DES ;
      private String[] T00119_A289PRG_NFI ;
      private String[] T00119_A290USU_CNT ;
      private DateTime[] T00119_A166PRS_INI ;
      private String[] T00119_A404PRS_UOB ;
      private String[] T00119_A405PRS_UDE ;
      private String[] T00119_A406PRS_ULNK ;
      private DateTime[] T00119_A165PRS_CAD ;
      private String[] T00119_A408PRS_DES ;
      private String[] T00119_A409PRS_LINK ;
      private String[] T00119_A6USU_COD ;
      private short[] T00119_A116SIS_COD ;
      private short[] T00119_A126PRG_COD ;
      private int[] T00119_A118PRS_NRO ;
      private DateTime[] T00118_A166PRS_INI ;
      private String[] T00118_A404PRS_UOB ;
      private String[] T00118_A405PRS_UDE ;
      private String[] T00118_A406PRS_ULNK ;
      private DateTime[] T00118_A165PRS_CAD ;
      private String[] T001110_A127PRG_DES ;
      private String[] T001110_A289PRG_NFI ;
      private String[] T001111_A290USU_CNT ;
      private DateTime[] T001112_A166PRS_INI ;
      private String[] T001112_A404PRS_UOB ;
      private String[] T001112_A405PRS_UDE ;
      private String[] T001112_A406PRS_ULNK ;
      private DateTime[] T001112_A165PRS_CAD ;
      private String[] T001113_A6USU_COD ;
      private short[] T001113_A116SIS_COD ;
      private short[] T001113_A126PRG_COD ;
      private int[] T001113_A118PRS_NRO ;
      private short[] T001113_A407PRS_ORD ;
      private short[] T00113_A407PRS_ORD ;
      private String[] T00113_A408PRS_DES ;
      private String[] T00113_A409PRS_LINK ;
      private String[] T00113_A6USU_COD ;
      private short[] T00113_A116SIS_COD ;
      private short[] T00113_A126PRG_COD ;
      private int[] T00113_A118PRS_NRO ;
      private String[] T001114_A6USU_COD ;
      private short[] T001114_A116SIS_COD ;
      private short[] T001114_A126PRG_COD ;
      private int[] T001114_A118PRS_NRO ;
      private short[] T001114_A407PRS_ORD ;
      private String[] T001115_A6USU_COD ;
      private short[] T001115_A116SIS_COD ;
      private short[] T001115_A126PRG_COD ;
      private int[] T001115_A118PRS_NRO ;
      private short[] T001115_A407PRS_ORD ;
      private short[] T001116_A407PRS_ORD ;
      private String[] T001116_A408PRS_DES ;
      private String[] T001116_A409PRS_LINK ;
      private String[] T001116_A6USU_COD ;
      private short[] T001116_A116SIS_COD ;
      private short[] T001116_A126PRG_COD ;
      private int[] T001116_A118PRS_NRO ;
      private String[] T001120_A127PRG_DES ;
      private String[] T001120_A289PRG_NFI ;
      private String[] T001121_A290USU_CNT ;
      private DateTime[] T001122_A166PRS_INI ;
      private String[] T001122_A404PRS_UOB ;
      private String[] T001122_A405PRS_UDE ;
      private String[] T001122_A406PRS_ULNK ;
      private DateTime[] T001122_A165PRS_CAD ;
      private String[] T001123_A6USU_COD ;
      private short[] T001123_A116SIS_COD ;
      private short[] T001123_A126PRG_COD ;
      private int[] T001123_A118PRS_NRO ;
      private short[] T001123_A407PRS_ORD ;
      private short[] T00112_A407PRS_ORD ;
      private String[] T00112_A408PRS_DES ;
      private String[] T00112_A409PRS_LINK ;
      private String[] T00112_A6USU_COD ;
      private short[] T00112_A116SIS_COD ;
      private short[] T00112_A126PRG_COD ;
      private int[] T00112_A118PRS_NRO ;
      private GXWebForm Form ;
   }

   public class tseg007__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00112 ;
          prmT00112 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00114 ;
          prmT00114 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00115 ;
          prmT00115 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00119 ;
          prmT00119 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00116 ;
          prmT00116 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00117 ;
          prmT00117 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00118 ;
          prmT00118 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001110 ;
          prmT001110 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001111 ;
          prmT001111 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001112 ;
          prmT001112 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001113 ;
          prmT001113 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00113 ;
          prmT00113 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001114 ;
          prmT001114 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001115 ;
          prmT001115 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001116 ;
          prmT001116 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001117 ;
          prmT001117 = new Object[] {
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRS_DES",SqlDbType.Char,30,0} ,
          new Object[] {"@PRS_LINK",SqlDbType.VarChar,300,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001118 ;
          prmT001118 = new Object[] {
          new Object[] {"@PRS_DES",SqlDbType.Char,30,0} ,
          new Object[] {"@PRS_LINK",SqlDbType.VarChar,300,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001119 ;
          prmT001119 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_ORD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001123 ;
          prmT001123 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001120 ;
          prmT001120 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001121 ;
          prmT001121 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001122 ;
          prmT001122 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00112", "SELECT [PRS_ORD], [PRS_DES], [PRS_LINK], [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG007] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00112,1,1,true,false )
             ,new CursorDef("T00113", "SELECT [PRS_ORD], [PRS_DES], [PRS_LINK], [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00113,1,1,true,false )
             ,new CursorDef("T00114", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00114,1,0,true,false )
             ,new CursorDef("T00115", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00115,1,1,true,false )
             ,new CursorDef("T00116", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00116,1,1,true,false )
             ,new CursorDef("T00117", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00117,1,1,true,false )
             ,new CursorDef("T00118", "SELECT [PRS_INI], [PRS_UOB], [PRS_UDE], [PRS_ULNK], [PRS_CAD] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00118,1,1,true,false )
             ,new CursorDef("T00119", "SELECT TM1.[PRS_ORD], T2.[USU_DES], T2.[USU_CLA], T3.[SIS_DES], T4.[PRG_DES], T4.[PRG_NFI], T5.[USU_CNT], T6.[PRS_INI], T6.[PRS_UOB], T6.[PRS_UDE], T6.[PRS_ULNK], T6.[PRS_CAD], TM1.[PRS_DES], TM1.[PRS_LINK], TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD], TM1.[PRS_NRO] FROM ((((([SEG007] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = TM1.[SIS_COD]) INNER JOIN [SEG001] T4 WITH (NOLOCK) ON T4.[PRG_COD] = TM1.[PRG_COD]) INNER JOIN [SEG004] T5 WITH (NOLOCK) ON T5.[USU_COD] = TM1.[USU_COD] AND T5.[SIS_COD] = TM1.[SIS_COD] AND T5.[PRG_COD] = TM1.[PRG_COD]) INNER JOIN [SEG006] T6 WITH (NOLOCK) ON T6.[USU_COD] = TM1.[USU_COD] AND T6.[SIS_COD] = TM1.[SIS_COD] AND T6.[PRG_COD] = TM1.[PRG_COD] AND T6.[PRS_NRO] = TM1.[PRS_NRO]) WHERE TM1.[USU_COD] = @USU_COD and TM1.[SIS_COD] = @SIS_COD and TM1.[PRG_COD] = @PRG_COD and TM1.[PRS_NRO] = @PRS_NRO and TM1.[PRS_ORD] = @PRS_ORD ORDER BY TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD], TM1.[PRS_NRO], TM1.[PRS_ORD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00119,100,0,true,false )
             ,new CursorDef("T001110", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001110,1,1,true,false )
             ,new CursorDef("T001111", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001111,1,1,true,false )
             ,new CursorDef("T001112", "SELECT [PRS_INI], [PRS_UOB], [PRS_UDE], [PRS_ULNK], [PRS_CAD] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT001112,1,1,true,false )
             ,new CursorDef("T001113", "SELECT [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001113,1,1,true,false )
             ,new CursorDef("T001114", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE ( [PRG_COD] > @PRG_COD or [PRG_COD] = @PRG_COD and [PRS_NRO] > @PRS_NRO or [PRS_NRO] = @PRS_NRO and [PRG_COD] = @PRG_COD and [PRS_ORD] > @PRS_ORD) and [USU_COD] = @USU_COD and [SIS_COD] = @SIS_COD ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001114,1,1,true,true )
             ,new CursorDef("T001115", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE ( [PRG_COD] < @PRG_COD or [PRG_COD] = @PRG_COD and [PRS_NRO] < @PRS_NRO or [PRS_NRO] = @PRS_NRO and [PRG_COD] = @PRG_COD and [PRS_ORD] < @PRS_ORD) and [USU_COD] = @USU_COD and [SIS_COD] = @SIS_COD ORDER BY [USU_COD] DESC, [SIS_COD] DESC, [PRG_COD] DESC, [PRS_NRO] DESC, [PRS_ORD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001115,1,1,true,true )
             ,new CursorDef("T001116", "SELECT [PRS_ORD], [PRS_DES], [PRS_LINK], [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG007] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001116,1,1,true,false )
             ,new CursorDef("T001117", "INSERT INTO [SEG007] ([PRS_ORD], [PRS_DES], [PRS_LINK], [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO]) VALUES (@PRS_ORD, @PRS_DES, @PRS_LINK, @USU_COD, @SIS_COD, @PRG_COD, @PRS_NRO)", GxErrorMask.GX_NOMASK,prmT001117)
             ,new CursorDef("T001118", "UPDATE [SEG007] SET [PRS_DES]=@PRS_DES, [PRS_LINK]=@PRS_LINK  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD", GxErrorMask.GX_NOMASK,prmT001118)
             ,new CursorDef("T001119", "DELETE FROM [SEG007]  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO AND [PRS_ORD] = @PRS_ORD", GxErrorMask.GX_NOMASK,prmT001119)
             ,new CursorDef("T001120", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001120,1,1,true,false )
             ,new CursorDef("T001121", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001121,1,1,true,false )
             ,new CursorDef("T001122", "SELECT [PRS_INI], [PRS_UOB], [PRS_UDE], [PRS_ULNK], [PRS_CAD] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT001122,1,1,true,false )
             ,new CursorDef("T001123", "SELECT [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD and [SIS_COD] = @SIS_COD ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001123,100,1,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 6 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 8) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 20) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 30) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(11) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 30) ;
                ((String[]) buf[13])[0] = rslt.getLongVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 16) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 10 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 20 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
