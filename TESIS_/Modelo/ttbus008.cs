/*
               File: TTBUS008
        Description: Actualización de Administradores Trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:52.48
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
   public class ttbus008 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A40TTBUS8_CodUsuario = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A40TTBUS8_CodUsuario) ;
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
            AV9TTBUS8_CodUsuario = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS8_CodUsuario", AV9TTBUS8_CodUsuario);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Administradores Trazabilidad", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus008( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus008( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_TTBUS8_CodUsuario ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV9TTBUS8_CodUsuario = aP0_TTBUS8_CodUsuario;
         this.Gx_mode = aP1_Gx_mode;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV8USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_TTBUS8_CodUsuario=this.AV9TTBUS8_CodUsuario;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV7SISTEMA;
         aP3_USUARIO=this.AV8USUARIO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_089( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_089e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_089( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_089( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_089e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Actualización de Administradores Trazabilidad"+"</legend>") ;
            wb_table3_27_089( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_089e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_089e( true) ;
         }
         else
         {
            wb_table1_2_089e( false) ;
         }
      }

      protected void wb_table3_27_089( bool wbgen )
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
            wb_table4_33_089( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_089e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS008.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS008.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_089e( true) ;
         }
         else
         {
            wb_table3_27_089e( false) ;
         }
      }

      protected void wb_table4_33_089( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus8_codusuario_Internalname, 1, 1, 0, "Cód. Usuario", "", "", "", 0, lblTextblockttbus8_codusuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS8_CodUsuario_Internalname, StringUtil.RTrim( A40TTBUS8_CodUsuario), "", 16, "chr", 1, "row", 16, 1, edtTTBUS8_CodUsuario_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A40TTBUS8_CodUsuario, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(38);\"", 0, edtTTBUS8_CodUsuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS008.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_40_Internalname, "", "prompt.gif", "Modern", imgprompt_40_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_40_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus8_desusuario_Internalname, 1, 1, 0, "Desc. Usuario", "", "", "", 0, lblTextblockttbus8_desusuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS8_DesUsuario_Internalname, StringUtil.RTrim( A200TTBUS8_DesUsuario), "", 50, "chr", 1, "row", 50, 1, edtTTBUS8_DesUsuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A200TTBUS8_DesUsuario, "@!")), "", 0, edtTTBUS8_DesUsuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_089e( true) ;
         }
         else
         {
            wb_table4_33_089e( false) ;
         }
      }

      protected void wb_table2_5_089( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS8_CODUSUARIO"+"'), id:'"+"TTBUS8_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS8_CODUSUARIO"+"'), id:'"+"TTBUS8_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS008.htm");
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
            wb_table2_5_089e( true) ;
         }
         else
         {
            wb_table2_5_089e( false) ;
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
               A40TTBUS8_CodUsuario = StringUtil.Upper( cgiGet( edtTTBUS8_CodUsuario_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               A200TTBUS8_DesUsuario = StringUtil.Upper( cgiGet( edtTTBUS8_DesUsuario_Internalname)) ;
               n200TTBUS8_DesUsuario = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
               /* Read saved values. */
               Z40TTBUS8_CodUsuario = cgiGet( "Z40TTBUS8_CodUsuario") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV9TTBUS8_CodUsuario = cgiGet( "vTTBUS8_CODUSUARIO") ;
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
                  A40TTBUS8_CodUsuario = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode9 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode9 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound9 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_080( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "TTBUS8_CODUSUARIO");
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll089( ) ;
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
            edtTTBUS8_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS8_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS8_CodUsuario_Enabled), 5, 0)));
            edtTTBUS8_DesUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS8_DesUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS8_DesUsuario_Enabled), 5, 0)));
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

      protected void CONFIRM_080( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls089( ) ;
            }
            else
            {
               CheckExtendedTable089( ) ;
               CloseExtendedTableCursors089( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption080( )
      {
      }

      protected void ZM089( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -4 )
         {
            Z40TTBUS8_CodUsuario = A40TTBUS8_CodUsuario ;
            Z200TTBUS8_DesUsuario = A200TTBUS8_DesUsuario ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS8_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS8_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS8_CodUsuario_Enabled), 5, 0)));
         }
         else
         {
            edtTTBUS8_CodUsuario_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS8_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS8_CodUsuario_Enabled), 5, 0)));
         }
         imgprompt_40_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS8_CODUSUARIO"+"'), id:'"+"TTBUS8_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A40TTBUS8_CodUsuario = AV9TTBUS8_CodUsuario ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS8_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS8_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS8_CodUsuario_Enabled), 5, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00084 */
            pr_default.execute(2, new Object[] {A40TTBUS8_CodUsuario});
            A200TTBUS8_DesUsuario = T00084_A200TTBUS8_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
            n200TTBUS8_DesUsuario = T00084_n200TTBUS8_DesUsuario[0] ;
            pr_default.close(2);
         }
      }

      protected void Load089( )
      {
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound9 = 1 ;
            A200TTBUS8_DesUsuario = T00085_A200TTBUS8_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
            n200TTBUS8_DesUsuario = T00085_n200TTBUS8_DesUsuario[0] ;
            ZM089( -4) ;
         }
         pr_default.close(3);
         OnLoadActions089( ) ;
      }

      protected void OnLoadActions089( )
      {
      }

      protected void CheckExtendedTable089( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Administrador de trazabilidad bienes de uso'.", "ForeignKeyNotFound", 1, "TTBUS8_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A200TTBUS8_DesUsuario = T00084_A200TTBUS8_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
            n200TTBUS8_DesUsuario = T00084_n200TTBUS8_DesUsuario[0] ;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors089( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A40TTBUS8_CodUsuario )
      {
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Administrador de trazabilidad bienes de uso'.", "ForeignKeyNotFound", 1, "TTBUS8_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A200TTBUS8_DesUsuario = T00086_A200TTBUS8_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
            n200TTBUS8_DesUsuario = T00086_n200TTBUS8_DesUsuario[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A200TTBUS8_DesUsuario))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey089( )
      {
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound9 = 1 ;
         }
         else
         {
            RcdFound9 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM089( 4) ;
            RcdFound9 = 1 ;
            A40TTBUS8_CodUsuario = T00083_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            Z40TTBUS8_CodUsuario = A40TTBUS8_CodUsuario ;
            sMode9 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load089( ) ;
            Gx_mode = sMode9 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0 ;
            InitializeNonKey089( ) ;
            sMode9 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey089( ) ;
         if ( RcdFound9 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound9 = 0 ;
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00088_A40TTBUS8_CodUsuario[0], A40TTBUS8_CodUsuario) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00088_A40TTBUS8_CodUsuario[0], A40TTBUS8_CodUsuario) > 0 ) ) )
            {
               A40TTBUS8_CodUsuario = T00088_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               RcdFound9 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0 ;
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00089_A40TTBUS8_CodUsuario[0], A40TTBUS8_CodUsuario) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00089_A40TTBUS8_CodUsuario[0], A40TTBUS8_CodUsuario) < 0 ) ) )
            {
               A40TTBUS8_CodUsuario = T00089_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               RcdFound9 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey089( ) ;
         if ( RcdFound9 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS8_CODUSUARIO");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A40TTBUS8_CodUsuario, Z40TTBUS8_CodUsuario) != 0 )
            {
               A40TTBUS8_CodUsuario = Z40TTBUS8_CodUsuario ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS8_CODUSUARIO");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update089( ) ;
               GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A40TTBUS8_CodUsuario, Z40TTBUS8_CodUsuario) != 0 )
            {
               /* Insert record */
               Insert089( ) ;
               GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS8_CODUSUARIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert089( ) ;
                  GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
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
         if ( StringUtil.StrCmp(A40TTBUS8_CodUsuario, Z40TTBUS8_CodUsuario) != 0 )
         {
            A40TTBUS8_CodUsuario = Z40TTBUS8_CodUsuario ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS8_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000810 */
            pr_default.execute(8, new Object[] {A40TTBUS8_CodUsuario});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS008"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS008"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM089( 0) ;
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000811 */
                     pr_default.execute(9, new Object[] {A40TTBUS8_CodUsuario});
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
                           ResetCaption080( ) ;
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
               Load089( ) ;
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void Update089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [TTBUS008] */
                     DeferredUpdate089( ) ;
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
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void DeferredUpdate089( )
      {
      }

      protected void delete( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls089( ) ;
            AfterConfirm089( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete089( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000812 */
                  pr_default.execute(10, new Object[] {A40TTBUS8_CodUsuario});
                  pr_default.close(10);
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
         sMode9 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel089( ) ;
         Gx_mode = sMode9 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls089( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000813 */
            pr_default.execute(11, new Object[] {A40TTBUS8_CodUsuario});
            A200TTBUS8_DesUsuario = T000813_A200TTBUS8_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
            n200TTBUS8_DesUsuario = T000813_n200TTBUS8_DesUsuario[0] ;
            pr_default.close(11);
         }
      }

      protected void EndLevel089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete089( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(11);
            context.CommitDataStores("TTBUS008");
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(11);
            context.RollbackDataStores("TTBUS008");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart089( )
      {
         /* Using cursor T000814 */
         pr_default.execute(12);
         RcdFound9 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound9 = 1 ;
            A40TTBUS8_CodUsuario = T000814_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext089( )
      {
         pr_default.readNext(12);
         RcdFound9 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound9 = 1 ;
            A40TTBUS8_CodUsuario = T000814_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
         }
      }

      protected void ScanEnd089( )
      {
      }

      protected void AfterConfirm089( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert089( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate089( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete089( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete089( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate089( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9TTBUS8_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z40TTBUS8_CodUsuario", StringUtil.RTrim( Z40TTBUS8_CodUsuario));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vTTBUS8_CODUSUARIO", StringUtil.RTrim( AV9TTBUS8_CodUsuario));
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
         return "TTBUS008" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Administradores Trazabilidad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9TTBUS8_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void InitializeNonKey089( )
      {
         A200TTBUS8_DesUsuario = "" ;
         n200TTBUS8_DesUsuario = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
      }

      protected void InitAll089( )
      {
         A40TTBUS8_CodUsuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
         InitializeNonKey089( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13225312");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus008.js", "?13225312");
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
         lblTextblockttbus8_codusuario_Internalname = "TEXTBLOCKTTBUS8_CODUSUARIO" ;
         edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO" ;
         lblTextblockttbus8_desusuario_Internalname = "TEXTBLOCKTTBUS8_DESUSUARIO" ;
         edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_40_Internalname = "PROMPT_40" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Administradores Trazabilidad" ;
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
         edtTTBUS8_DesUsuario_Jsonclick = "" ;
         edtTTBUS8_DesUsuario_Enabled = 0 ;
         imgprompt_40_Visible = 1 ;
         imgprompt_40_Link = "" ;
         edtTTBUS8_CodUsuario_Jsonclick = "" ;
         edtTTBUS8_CodUsuario_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Ttbus8_codusuario( String GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A40TTBUS8_CodUsuario = GX_Parm1 ;
         A200TTBUS8_DesUsuario = GX_Parm2 ;
         n200TTBUS8_DesUsuario = false ;
         /* Using cursor T000813 */
         pr_default.execute(11, new Object[] {A40TTBUS8_CodUsuario});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Administrador de trazabilidad bienes de uso'.", "ForeignKeyNotFound", 1, "TTBUS8_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS8_CodUsuario_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A200TTBUS8_DesUsuario = T000813_A200TTBUS8_DesUsuario[0] ;
            n200TTBUS8_DesUsuario = T000813_n200TTBUS8_DesUsuario[0] ;
         }
         pr_default.close(11);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A200TTBUS8_DesUsuario = "" ;
            n200TTBUS8_DesUsuario = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A200TTBUS8_DesUsuario)));
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
         pr_default.close(12);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOAV9TTBUS8_CodUsuario = "" ;
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A40TTBUS8_CodUsuario = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockttbus8_codusuario_Jsonclick = "" ;
         lblTextblockttbus8_desusuario_Jsonclick = "" ;
         A200TTBUS8_DesUsuario = "" ;
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
         Z40TTBUS8_CodUsuario = "" ;
         sMode9 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z200TTBUS8_DesUsuario = "" ;
         T00084_A200TTBUS8_DesUsuario = new String[] {""} ;
         T00084_n200TTBUS8_DesUsuario = new bool[] {false} ;
         T00085_A200TTBUS8_DesUsuario = new String[] {""} ;
         T00085_n200TTBUS8_DesUsuario = new bool[] {false} ;
         T00085_A40TTBUS8_CodUsuario = new String[] {""} ;
         T00086_A200TTBUS8_DesUsuario = new String[] {""} ;
         T00086_n200TTBUS8_DesUsuario = new bool[] {false} ;
         T00087_A40TTBUS8_CodUsuario = new String[] {""} ;
         T00083_A40TTBUS8_CodUsuario = new String[] {""} ;
         T00088_A40TTBUS8_CodUsuario = new String[] {""} ;
         T00089_A40TTBUS8_CodUsuario = new String[] {""} ;
         T000810_A40TTBUS8_CodUsuario = new String[] {""} ;
         T000813_A200TTBUS8_DesUsuario = new String[] {""} ;
         T000813_n200TTBUS8_DesUsuario = new bool[] {false} ;
         T000814_A40TTBUS8_CodUsuario = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus008__default(),
            new Object[][] {
                new Object[] {
               T00082_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T00083_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T00084_A200TTBUS8_DesUsuario, T00084_n200TTBUS8_DesUsuario
               }
               , new Object[] {
               T00085_A200TTBUS8_DesUsuario, T00085_n200TTBUS8_DesUsuario, T00085_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T00086_A200TTBUS8_DesUsuario, T00086_n200TTBUS8_DesUsuario
               }
               , new Object[] {
               T00087_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T00088_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T00089_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T000810_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000813_A200TTBUS8_DesUsuario, T000813_n200TTBUS8_DesUsuario
               }
               , new Object[] {
               T000814_A40TTBUS8_CodUsuario
               }
            }
         );
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound9 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS8_CodUsuario_Enabled ;
      private int imgprompt_40_Visible ;
      private int edtTTBUS8_DesUsuario_Enabled ;
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
      private int idxLst ;
      private String sPrefix ;
      private String wcpOAV9TTBUS8_CodUsuario ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A40TTBUS8_CodUsuario ;
      private String AV9TTBUS8_CodUsuario ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS8_CodUsuario_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus8_codusuario_Internalname ;
      private String lblTextblockttbus8_codusuario_Jsonclick ;
      private String edtTTBUS8_CodUsuario_Jsonclick ;
      private String imgprompt_40_Internalname ;
      private String imgprompt_40_Link ;
      private String lblTextblockttbus8_desusuario_Internalname ;
      private String lblTextblockttbus8_desusuario_Jsonclick ;
      private String edtTTBUS8_DesUsuario_Internalname ;
      private String A200TTBUS8_DesUsuario ;
      private String edtTTBUS8_DesUsuario_Jsonclick ;
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
      private String Z40TTBUS8_CodUsuario ;
      private String sMode9 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z200TTBUS8_DesUsuario ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n200TTBUS8_DesUsuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private String aP0_TTBUS8_CodUsuario ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] T00084_A200TTBUS8_DesUsuario ;
      private bool[] T00084_n200TTBUS8_DesUsuario ;
      private String[] T00085_A200TTBUS8_DesUsuario ;
      private bool[] T00085_n200TTBUS8_DesUsuario ;
      private String[] T00085_A40TTBUS8_CodUsuario ;
      private String[] T00086_A200TTBUS8_DesUsuario ;
      private bool[] T00086_n200TTBUS8_DesUsuario ;
      private String[] T00087_A40TTBUS8_CodUsuario ;
      private String[] T00083_A40TTBUS8_CodUsuario ;
      private String[] T00088_A40TTBUS8_CodUsuario ;
      private String[] T00089_A40TTBUS8_CodUsuario ;
      private String[] T000810_A40TTBUS8_CodUsuario ;
      private String[] T000813_A200TTBUS8_DesUsuario ;
      private bool[] T000813_n200TTBUS8_DesUsuario ;
      private String[] T000814_A40TTBUS8_CodUsuario ;
      private String[] T00082_A40TTBUS8_CodUsuario ;
      private GXWebForm Form ;
   }

   public class ttbus008__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000812 ;
          prmT000812 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000814 ;
          prmT000814 = new Object[] {
          } ;
          Object[] prmT000813 ;
          prmT000813 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (UPDLOCK) WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
             ,new CursorDef("T00083", "SELECT [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
             ,new CursorDef("T00084", "SELECT [USU_DES] AS TTBUS8_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
             ,new CursorDef("T00085", "SELECT T2.[USU_DES] AS TTBUS8_DesUsuario, TM1.[TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM ([TTBUS008] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[TTBUS8_CodUsuario]) WHERE TM1.[TTBUS8_CodUsuario] = @TTBUS8_CodUsuario ORDER BY TM1.[TTBUS8_CodUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,100,0,true,false )
             ,new CursorDef("T00086", "SELECT [USU_DES] AS TTBUS8_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,1,0,true,false )
             ,new CursorDef("T00087", "SELECT [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
             ,new CursorDef("T00088", "SELECT TOP 1 [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (NOLOCK) WHERE ( [TTBUS8_CodUsuario] > @TTBUS8_CodUsuario) ORDER BY [TTBUS8_CodUsuario]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,true )
             ,new CursorDef("T00089", "SELECT TOP 1 [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (NOLOCK) WHERE ( [TTBUS8_CodUsuario] < @TTBUS8_CodUsuario) ORDER BY [TTBUS8_CodUsuario] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,true )
             ,new CursorDef("T000810", "SELECT [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (UPDLOCK) WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,false )
             ,new CursorDef("T000811", "INSERT INTO [TTBUS008] ([TTBUS8_CodUsuario]) VALUES (@TTBUS8_CodUsuario)", GxErrorMask.GX_NOMASK,prmT000811)
             ,new CursorDef("T000812", "DELETE FROM [TTBUS008]  WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario", GxErrorMask.GX_NOMASK,prmT000812)
             ,new CursorDef("T000813", "SELECT [USU_DES] AS TTBUS8_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS8_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000813,1,0,true,false )
             ,new CursorDef("T000814", "SELECT [TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM [TTBUS008] WITH (NOLOCK) ORDER BY [TTBUS8_CodUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000814,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
