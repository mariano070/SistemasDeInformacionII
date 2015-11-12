/*
               File: GESTORES
        Description: Gestores
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:15.13
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
   public class gestores : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A260GestorCod = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A260GestorCod) ;
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
               AV13GestorCod = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorCod", AV13GestorCod);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Gestores", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtGestorCod_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public gestores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gestores( IGxContext context )
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
                           String aP1_GestorCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV13GestorCod = aP1_GestorCod;
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
            wb_table1_2_0H17( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0H17e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0H17( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0H17( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0H17e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Gestores"+"</legend>") ;
            wb_table3_27_0H17( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0H17e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0H17e( true) ;
         }
         else
         {
            wb_table1_2_0H17e( false) ;
         }
      }

      protected void wb_table3_27_0H17( bool wbgen )
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
            wb_table4_33_0H17( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0H17e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_GESTORES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_GESTORES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_GESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0H17e( true) ;
         }
         else
         {
            wb_table3_27_0H17e( false) ;
         }
      }

      protected void wb_table4_33_0H17( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorcod_Internalname, 1, 1, 0, "Cod Gestor", "", "", "", 0, lblTextblockgestorcod_Jsonclick, "", StyleString, ClassString, "HLP_GESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGestorCod_Internalname, StringUtil.RTrim( A260GestorCod), "", 15, "chr", 1, "row", 15, 1, edtGestorCod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A260GestorCod, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(38);\"", 0, edtGestorCod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GESTORES.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_260_Internalname, "", "prompt.gif", "Modern", imgprompt_260_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_260_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_GESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:25px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestordes_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockgestordes_Jsonclick, "", StyleString, ClassString, "HLP_GESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGestorDes_Internalname, StringUtil.RTrim( A269GestorDes), "", 50, "chr", 1, "row", 50, 1, edtGestorDes_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A269GestorDes, "@!")), "", 0, edtGestorDes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0H17e( true) ;
         }
         else
         {
            wb_table4_33_0H17e( false) ;
         }
      }

      protected void wb_table2_5_0H17( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GESTORCOD"+"'), id:'"+"GESTORCOD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GESTORCOD"+"'), id:'"+"GESTORCOD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORES.htm");
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
            wb_table2_5_0H17e( true) ;
         }
         else
         {
            wb_table2_5_0H17e( false) ;
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
         /* Execute user event: E110H2 */
         E110H2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A260GestorCod = StringUtil.Upper( cgiGet( edtGestorCod_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               A269GestorDes = StringUtil.Upper( cgiGet( edtGestorDes_Internalname)) ;
               n269GestorDes = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
               /* Read saved values. */
               Z260GestorCod = cgiGet( "Z260GestorCod") ;
               Z263GestorRolCod = (short)(context.localUtil.CToN( cgiGet( "Z263GestorRolCod"), ",", ".")) ;
               Z261GestorRolDes = cgiGet( "Z261GestorRolDes") ;
               Z265GestorRamoCod = (short)(context.localUtil.CToN( cgiGet( "Z265GestorRamoCod"), ",", ".")) ;
               Z267GestorRamoDes = cgiGet( "Z267GestorRamoDes") ;
               A263GestorRolCod = (short)(context.localUtil.CToN( cgiGet( "Z263GestorRolCod"), ",", ".")) ;
               n263GestorRolCod = false ;
               A261GestorRolDes = cgiGet( "Z261GestorRolDes") ;
               A265GestorRamoCod = (short)(context.localUtil.CToN( cgiGet( "Z265GestorRamoCod"), ",", ".")) ;
               n265GestorRamoCod = false ;
               A267GestorRamoDes = cgiGet( "Z267GestorRamoDes") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV13GestorCod = cgiGet( "vGESTORCOD") ;
               A263GestorRolCod = (short)(context.localUtil.CToN( cgiGet( "GESTORROLCOD"), ",", ".")) ;
               A261GestorRolDes = cgiGet( "GESTORROLDES") ;
               A265GestorRamoCod = (short)(context.localUtil.CToN( cgiGet( "GESTORRAMOCOD"), ",", ".")) ;
               A267GestorRamoDes = cgiGet( "GESTORRAMODES") ;
               AV15Pgmname = cgiGet( "vPGMNAME") ;
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
                  A260GestorCod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
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
                     sMode17 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode17 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound17 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0H0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "GESTORCOD");
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
                           /* Execute user event: E110H2 */
                           E110H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120H2 */
                           E120H2 ();
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
            /* Execute user event: E120H2 */
            E120H2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0H17( ) ;
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
            edtGestorCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGestorCod_Enabled), 5, 0)));
            edtGestorDes_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorDes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGestorDes_Enabled), 5, 0)));
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H17( ) ;
            }
            else
            {
               CheckExtendedTable0H17( ) ;
               CloseExtendedTableCursors0H17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0H0( )
      {
      }

      protected void E110H2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV15Pgmname, out  AV8IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8IsAuthorized", StringUtil.BoolToStr( AV8IsAuthorized));
         if ( ! AV8IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)) ;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), "");
      }

      protected void E120H2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwgestores.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0H17( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z263GestorRolCod = T000H3_A263GestorRolCod[0] ;
               Z261GestorRolDes = T000H3_A261GestorRolDes[0] ;
               Z265GestorRamoCod = T000H3_A265GestorRamoCod[0] ;
               Z267GestorRamoDes = T000H3_A267GestorRamoDes[0] ;
            }
            else
            {
               Z263GestorRolCod = A263GestorRolCod ;
               Z261GestorRolDes = A261GestorRolDes ;
               Z265GestorRamoCod = A265GestorRamoCod ;
               Z267GestorRamoDes = A267GestorRamoDes ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z263GestorRolCod = A263GestorRolCod ;
            Z261GestorRolDes = A261GestorRolDes ;
            Z265GestorRamoCod = A265GestorRamoCod ;
            Z267GestorRamoDes = A267GestorRamoDes ;
            Z260GestorCod = A260GestorCod ;
            Z269GestorDes = A269GestorDes ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_260_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GESTORCOD"+"'), id:'"+"GESTORCOD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GestorCod)) )
         {
            A260GestorCod = AV13GestorCod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GestorCod)) )
         {
            edtGestorCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGestorCod_Enabled), 5, 0)));
         }
         else
         {
            edtGestorCod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGestorCod_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GestorCod)) )
         {
            edtGestorCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGestorCod_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
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
            /* Using cursor T000H4 */
            pr_default.execute(2, new Object[] {A260GestorCod});
            A269GestorDes = T000H4_A269GestorDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
            n269GestorDes = T000H4_n269GestorDes[0] ;
            pr_default.close(2);
            AV15Pgmname = "GESTORES" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         }
      }

      protected void Load0H17( )
      {
         /* Using cursor T000H5 */
         pr_default.execute(3, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound17 = 1 ;
            A269GestorDes = T000H5_A269GestorDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
            n269GestorDes = T000H5_n269GestorDes[0] ;
            A263GestorRolCod = T000H5_A263GestorRolCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263GestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A263GestorRolCod), 4, 0)));
            n263GestorRolCod = T000H5_n263GestorRolCod[0] ;
            A261GestorRolDes = T000H5_A261GestorRolDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261GestorRolDes", A261GestorRolDes);
            A265GestorRamoCod = T000H5_A265GestorRamoCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
            n265GestorRamoCod = T000H5_n265GestorRamoCod[0] ;
            A267GestorRamoDes = T000H5_A267GestorRamoDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267GestorRamoDes", A267GestorRamoDes);
            ZM0H17( -4) ;
         }
         pr_default.close(3);
         OnLoadActions0H17( ) ;
      }

      protected void OnLoadActions0H17( )
      {
         AV15Pgmname = "GESTORES" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0H17( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV15Pgmname = "GESTORES" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario Gestor'.", "ForeignKeyNotFound", 1, "GESTORCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGestorCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A269GestorDes = T000H4_A269GestorDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
            n269GestorDes = T000H4_n269GestorDes[0] ;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0H17( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A260GestorCod )
      {
         /* Using cursor T000H6 */
         pr_default.execute(4, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario Gestor'.", "ForeignKeyNotFound", 1, "GESTORCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGestorCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A269GestorDes = T000H6_A269GestorDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
            n269GestorDes = T000H6_n269GestorDes[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A269GestorDes))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0H17( )
      {
         /* Using cursor T000H7 */
         pr_default.execute(5, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound17 = 1 ;
         }
         else
         {
            RcdFound17 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000H3 */
         pr_default.execute(1, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H17( 4) ;
            RcdFound17 = 1 ;
            A263GestorRolCod = T000H3_A263GestorRolCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263GestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A263GestorRolCod), 4, 0)));
            n263GestorRolCod = T000H3_n263GestorRolCod[0] ;
            A261GestorRolDes = T000H3_A261GestorRolDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261GestorRolDes", A261GestorRolDes);
            A265GestorRamoCod = T000H3_A265GestorRamoCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
            n265GestorRamoCod = T000H3_n265GestorRamoCod[0] ;
            A267GestorRamoDes = T000H3_A267GestorRamoDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267GestorRamoDes", A267GestorRamoDes);
            A260GestorCod = T000H3_A260GestorCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
            Z260GestorCod = A260GestorCod ;
            sMode17 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0H17( ) ;
            Gx_mode = sMode17 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound17 = 0 ;
            InitializeNonKey0H17( ) ;
            sMode17 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode17 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H17( ) ;
         if ( RcdFound17 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound17 = 0 ;
         /* Using cursor T000H8 */
         pr_default.execute(6, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000H8_A260GestorCod[0], A260GestorCod) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000H8_A260GestorCod[0], A260GestorCod) > 0 ) ) )
            {
               A260GestorCod = T000H8_A260GestorCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               RcdFound17 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound17 = 0 ;
         /* Using cursor T000H9 */
         pr_default.execute(7, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000H9_A260GestorCod[0], A260GestorCod) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000H9_A260GestorCod[0], A260GestorCod) < 0 ) ) )
            {
               A260GestorCod = T000H9_A260GestorCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               RcdFound17 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0H17( ) ;
         if ( RcdFound17 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "GESTORCOD");
               AnyError = 1 ;
               GX_FocusControl = edtGestorCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A260GestorCod, Z260GestorCod) != 0 )
            {
               A260GestorCod = Z260GestorCod ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "GESTORCOD");
               AnyError = 1 ;
               GX_FocusControl = edtGestorCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtGestorCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0H17( ) ;
               GX_FocusControl = edtGestorCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A260GestorCod, Z260GestorCod) != 0 )
            {
               /* Insert record */
               Insert0H17( ) ;
               GX_FocusControl = edtGestorCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "GESTORCOD");
                  AnyError = 1 ;
                  GX_FocusControl = edtGestorCod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0H17( ) ;
                  GX_FocusControl = edtGestorCod_Internalname ;
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
         if ( StringUtil.StrCmp(A260GestorCod, Z260GestorCod) != 0 )
         {
            A260GestorCod = Z260GestorCod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "GESTORCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGestorCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtGestorCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H10 */
            pr_default.execute(8, new Object[] {A260GestorCod});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GESTORES"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( Z263GestorRolCod != T000H10_A263GestorRolCod[0] ) || ( StringUtil.StrCmp(Z261GestorRolDes, T000H10_A261GestorRolDes[0]) != 0 ) || ( Z265GestorRamoCod != T000H10_A265GestorRamoCod[0] ) || ( StringUtil.StrCmp(Z267GestorRamoDes, T000H10_A267GestorRamoDes[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"GESTORES"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H17( 0) ;
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H11 */
                     pr_default.execute(9, new Object[] {n263GestorRolCod, A263GestorRolCod, A261GestorRolDes, n265GestorRamoCod, A265GestorRamoCod, A267GestorRamoDes, A260GestorCod});
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
                           ResetCaption0H0( ) ;
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
               Load0H17( ) ;
            }
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void Update0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H12 */
                     pr_default.execute(10, new Object[] {n263GestorRolCod, A263GestorRolCod, A261GestorRolDes, n265GestorRamoCod, A265GestorRamoCod, A267GestorRamoDes, A260GestorCod});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GESTORES"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0H17( ) ;
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
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void DeferredUpdate0H17( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H17( ) ;
            AfterConfirm0H17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000H13 */
                  pr_default.execute(11, new Object[] {A260GestorCod});
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
         sMode17 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0H17( ) ;
         Gx_mode = sMode17 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0H17( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "GESTORES" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000H14 */
            pr_default.execute(12, new Object[] {A260GestorCod});
            A269GestorDes = T000H14_A269GestorDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
            n269GestorDes = T000H14_n269GestorDes[0] ;
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H15 */
            pr_default.execute(13, new Object[] {A260GestorCod});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"EMP_ GST"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
            /* Using cursor T000H16 */
            pr_default.execute(14, new Object[] {A260GestorCod});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Gestores por Grupo"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
         }
      }

      protected void EndLevel0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("GESTORES");
            if ( AnyError == 0 )
            {
               ConfirmValues0H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.RollbackDataStores("GESTORES");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0H17( )
      {
         /* Using cursor T000H17 */
         pr_default.execute(15);
         RcdFound17 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound17 = 1 ;
            A260GestorCod = T000H17_A260GestorCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H17( )
      {
         pr_default.readNext(15);
         RcdFound17 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound17 = 1 ;
            A260GestorCod = T000H17_A260GestorCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
         }
      }

      protected void ScanEnd0H17( )
      {
      }

      protected void AfterConfirm0H17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H17( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H17( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H17( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0H0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV13GestorCod))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z260GestorCod", StringUtil.RTrim( Z260GestorCod));
         GxWebStd.gx_hidden_field( context, "Z263GestorRolCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z263GestorRolCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z261GestorRolDes", StringUtil.RTrim( Z261GestorRolDes));
         GxWebStd.gx_hidden_field( context, "Z265GestorRamoCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z265GestorRamoCod), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z267GestorRamoDes", StringUtil.RTrim( Z267GestorRamoDes));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vGESTORCOD", StringUtil.RTrim( AV13GestorCod));
         GxWebStd.gx_hidden_field( context, "GESTORROLCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A263GestorRolCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GESTORROLDES", StringUtil.RTrim( A261GestorRolDes));
         GxWebStd.gx_hidden_field( context, "GESTORRAMOCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A265GestorRamoCod), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GESTORRAMODES", StringUtil.RTrim( A267GestorRamoDes));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
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
         return "GESTORES" ;
      }

      public override String GetPgmdesc( )
      {
         return "Gestores" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV13GestorCod)) ;
      }

      protected void InitializeNonKey0H17( )
      {
         A269GestorDes = "" ;
         n269GestorDes = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
         A263GestorRolCod = 0 ;
         n263GestorRolCod = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263GestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A263GestorRolCod), 4, 0)));
         A261GestorRolDes = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261GestorRolDes", A261GestorRolDes);
         A265GestorRamoCod = 0 ;
         n265GestorRamoCod = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
         A267GestorRamoDes = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267GestorRamoDes", A267GestorRamoDes);
      }

      protected void InitAll0H17( )
      {
         A260GestorCod = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
         InitializeNonKey0H17( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?1915234");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19171619");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gestores.js", "?19171619");
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
         lblTextblockgestorcod_Internalname = "TEXTBLOCKGESTORCOD" ;
         edtGestorCod_Internalname = "GESTORCOD" ;
         lblTextblockgestordes_Internalname = "TEXTBLOCKGESTORDES" ;
         edtGestorDes_Internalname = "GESTORDES" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_260_Internalname = "PROMPT_260" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Gestores" ;
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
         edtGestorDes_Jsonclick = "" ;
         edtGestorDes_Enabled = 0 ;
         imgprompt_260_Visible = 1 ;
         imgprompt_260_Link = "" ;
         edtGestorCod_Jsonclick = "" ;
         edtGestorCod_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Gestorcod( String GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A260GestorCod = GX_Parm1 ;
         A269GestorDes = GX_Parm2 ;
         n269GestorDes = false ;
         /* Using cursor T000H14 */
         pr_default.execute(12, new Object[] {A260GestorCod});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario Gestor'.", "ForeignKeyNotFound", 1, "GESTORCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGestorCod_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A269GestorDes = T000H14_A269GestorDes[0] ;
            n269GestorDes = T000H14_n269GestorDes[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A269GestorDes = "" ;
            n269GestorDes = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A269GestorDes)));
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
         pr_default.close(15);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV13GestorCod = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A260GestorCod = "" ;
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
         lblTextblockgestorcod_Jsonclick = "" ;
         lblTextblockgestordes_Jsonclick = "" ;
         A269GestorDes = "" ;
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
         Z260GestorCod = "" ;
         Z261GestorRolDes = "" ;
         Z267GestorRamoDes = "" ;
         A261GestorRolDes = "" ;
         A267GestorRamoDes = "" ;
         AV15Pgmname = "" ;
         sMode17 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = new GxWebSession( context);
         Z269GestorDes = "" ;
         T000H4_A269GestorDes = new String[] {""} ;
         T000H4_n269GestorDes = new bool[] {false} ;
         T000H5_A269GestorDes = new String[] {""} ;
         T000H5_n269GestorDes = new bool[] {false} ;
         T000H5_A263GestorRolCod = new short[1] ;
         T000H5_n263GestorRolCod = new bool[] {false} ;
         T000H5_A261GestorRolDes = new String[] {""} ;
         T000H5_A265GestorRamoCod = new short[1] ;
         T000H5_n265GestorRamoCod = new bool[] {false} ;
         T000H5_A267GestorRamoDes = new String[] {""} ;
         T000H5_A260GestorCod = new String[] {""} ;
         T000H6_A269GestorDes = new String[] {""} ;
         T000H6_n269GestorDes = new bool[] {false} ;
         T000H7_A260GestorCod = new String[] {""} ;
         T000H3_A263GestorRolCod = new short[1] ;
         T000H3_n263GestorRolCod = new bool[] {false} ;
         T000H3_A261GestorRolDes = new String[] {""} ;
         T000H3_A265GestorRamoCod = new short[1] ;
         T000H3_n265GestorRamoCod = new bool[] {false} ;
         T000H3_A267GestorRamoDes = new String[] {""} ;
         T000H3_A260GestorCod = new String[] {""} ;
         T000H8_A260GestorCod = new String[] {""} ;
         T000H9_A260GestorCod = new String[] {""} ;
         T000H10_A263GestorRolCod = new short[1] ;
         T000H10_n263GestorRolCod = new bool[] {false} ;
         T000H10_A261GestorRolDes = new String[] {""} ;
         T000H10_A265GestorRamoCod = new short[1] ;
         T000H10_n265GestorRamoCod = new bool[] {false} ;
         T000H10_A267GestorRamoDes = new String[] {""} ;
         T000H10_A260GestorCod = new String[] {""} ;
         T000H14_A269GestorDes = new String[] {""} ;
         T000H14_n269GestorDes = new bool[] {false} ;
         T000H15_A291EmpGstCod = new int[1] ;
         T000H16_A271Grupo_Cod = new short[1] ;
         T000H16_A270Ges_Cod = new String[] {""} ;
         T000H17_A260GestorCod = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gestores__default(),
            new Object[][] {
                new Object[] {
               T000H2_A263GestorRolCod, T000H2_n263GestorRolCod, T000H2_A261GestorRolDes, T000H2_A265GestorRamoCod, T000H2_n265GestorRamoCod, T000H2_A267GestorRamoDes, T000H2_A260GestorCod
               }
               , new Object[] {
               T000H3_A263GestorRolCod, T000H3_n263GestorRolCod, T000H3_A261GestorRolDes, T000H3_A265GestorRamoCod, T000H3_n265GestorRamoCod, T000H3_A267GestorRamoDes, T000H3_A260GestorCod
               }
               , new Object[] {
               T000H4_A269GestorDes, T000H4_n269GestorDes
               }
               , new Object[] {
               T000H5_A269GestorDes, T000H5_n269GestorDes, T000H5_A263GestorRolCod, T000H5_n263GestorRolCod, T000H5_A261GestorRolDes, T000H5_A265GestorRamoCod, T000H5_n265GestorRamoCod, T000H5_A267GestorRamoDes, T000H5_A260GestorCod
               }
               , new Object[] {
               T000H6_A269GestorDes, T000H6_n269GestorDes
               }
               , new Object[] {
               T000H7_A260GestorCod
               }
               , new Object[] {
               T000H8_A260GestorCod
               }
               , new Object[] {
               T000H9_A260GestorCod
               }
               , new Object[] {
               T000H10_A263GestorRolCod, T000H10_n263GestorRolCod, T000H10_A261GestorRolDes, T000H10_A265GestorRamoCod, T000H10_n265GestorRamoCod, T000H10_A267GestorRamoDes, T000H10_A260GestorCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H14_A269GestorDes, T000H14_n269GestorDes
               }
               , new Object[] {
               T000H15_A291EmpGstCod
               }
               , new Object[] {
               T000H16_A271Grupo_Cod, T000H16_A270Ges_Cod
               }
               , new Object[] {
               T000H17_A260GestorCod
               }
            }
         );
         AV15Pgmname = "GESTORES" ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z263GestorRolCod ;
      private short Z265GestorRamoCod ;
      private short A263GestorRolCod ;
      private short A265GestorRamoCod ;
      private short RcdFound17 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtGestorCod_Enabled ;
      private int imgprompt_260_Visible ;
      private int edtGestorDes_Enabled ;
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
      private String wcpOGx_mode ;
      private String wcpOAV13GestorCod ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A260GestorCod ;
      private String Gx_mode ;
      private String AV13GestorCod ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtGestorCod_Internalname ;
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
      private String lblTextblockgestorcod_Internalname ;
      private String lblTextblockgestorcod_Jsonclick ;
      private String edtGestorCod_Jsonclick ;
      private String imgprompt_260_Internalname ;
      private String imgprompt_260_Link ;
      private String lblTextblockgestordes_Internalname ;
      private String lblTextblockgestordes_Jsonclick ;
      private String edtGestorDes_Internalname ;
      private String A269GestorDes ;
      private String edtGestorDes_Jsonclick ;
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
      private String Z260GestorCod ;
      private String Z261GestorRolDes ;
      private String Z267GestorRamoDes ;
      private String A261GestorRolDes ;
      private String A267GestorRamoDes ;
      private String AV15Pgmname ;
      private String sMode17 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z269GestorDes ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n269GestorDes ;
      private bool n263GestorRolCod ;
      private bool n265GestorRamoCod ;
      private bool AV8IsAuthorized ;
      private bool returnInSub ;
      private GxWebSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000H4_A269GestorDes ;
      private bool[] T000H4_n269GestorDes ;
      private String[] T000H5_A269GestorDes ;
      private bool[] T000H5_n269GestorDes ;
      private short[] T000H5_A263GestorRolCod ;
      private bool[] T000H5_n263GestorRolCod ;
      private String[] T000H5_A261GestorRolDes ;
      private short[] T000H5_A265GestorRamoCod ;
      private bool[] T000H5_n265GestorRamoCod ;
      private String[] T000H5_A267GestorRamoDes ;
      private String[] T000H5_A260GestorCod ;
      private String[] T000H6_A269GestorDes ;
      private bool[] T000H6_n269GestorDes ;
      private String[] T000H7_A260GestorCod ;
      private short[] T000H3_A263GestorRolCod ;
      private bool[] T000H3_n263GestorRolCod ;
      private String[] T000H3_A261GestorRolDes ;
      private short[] T000H3_A265GestorRamoCod ;
      private bool[] T000H3_n265GestorRamoCod ;
      private String[] T000H3_A267GestorRamoDes ;
      private String[] T000H3_A260GestorCod ;
      private String[] T000H8_A260GestorCod ;
      private String[] T000H9_A260GestorCod ;
      private short[] T000H10_A263GestorRolCod ;
      private bool[] T000H10_n263GestorRolCod ;
      private String[] T000H10_A261GestorRolDes ;
      private short[] T000H10_A265GestorRamoCod ;
      private bool[] T000H10_n265GestorRamoCod ;
      private String[] T000H10_A267GestorRamoDes ;
      private String[] T000H10_A260GestorCod ;
      private String[] T000H14_A269GestorDes ;
      private bool[] T000H14_n269GestorDes ;
      private int[] T000H15_A291EmpGstCod ;
      private short[] T000H16_A271Grupo_Cod ;
      private String[] T000H16_A270Ges_Cod ;
      private String[] T000H17_A260GestorCod ;
      private short[] T000H2_A263GestorRolCod ;
      private String[] T000H2_A261GestorRolDes ;
      private short[] T000H2_A265GestorRamoCod ;
      private String[] T000H2_A267GestorRamoDes ;
      private String[] T000H2_A260GestorCod ;
      private bool[] T000H2_n263GestorRolCod ;
      private bool[] T000H2_n265GestorRamoCod ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class gestores__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[15])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000H2 ;
          prmT000H2 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H5 ;
          prmT000H5 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H4 ;
          prmT000H4 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H6 ;
          prmT000H6 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H7 ;
          prmT000H7 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H3 ;
          prmT000H3 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H8 ;
          prmT000H8 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H9 ;
          prmT000H9 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H10 ;
          prmT000H10 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H11 ;
          prmT000H11 = new Object[] {
          new Object[] {"@GestorRolCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GestorRolDes",SqlDbType.Char,20,0} ,
          new Object[] {"@GestorRamoCod",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@GestorRamoDes",SqlDbType.Char,30,0} ,
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H12 ;
          prmT000H12 = new Object[] {
          new Object[] {"@GestorRolCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GestorRolDes",SqlDbType.Char,20,0} ,
          new Object[] {"@GestorRamoCod",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@GestorRamoDes",SqlDbType.Char,30,0} ,
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H13 ;
          prmT000H13 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H15 ;
          prmT000H15 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H16 ;
          prmT000H16 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000H17 ;
          prmT000H17 = new Object[] {
          } ;
          Object[] prmT000H14 ;
          prmT000H14 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000H2", "SELECT [GestorRolCod], [GestorRolDes], [GestorRamoCod], [GestorRamoDes], [GestorCod] AS GestorCod FROM [GESTORES] WITH (UPDLOCK) WHERE [GestorCod] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H2,1,0,true,false )
             ,new CursorDef("T000H3", "SELECT [GestorRolCod], [GestorRolDes], [GestorRamoCod], [GestorRamoDes], [GestorCod] AS GestorCod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H3,1,0,true,false )
             ,new CursorDef("T000H4", "SELECT [USU_DES] AS GestorDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H4,1,0,true,false )
             ,new CursorDef("T000H5", "SELECT T2.[USU_DES] AS GestorDes, TM1.[GestorRolCod], TM1.[GestorRolDes], TM1.[GestorRamoCod], TM1.[GestorRamoDes], TM1.[GestorCod] AS GestorCod FROM ([GESTORES] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[GestorCod]) WHERE TM1.[GestorCod] = @GestorCod ORDER BY TM1.[GestorCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H5,100,0,true,false )
             ,new CursorDef("T000H6", "SELECT [USU_DES] AS GestorDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H6,1,0,true,false )
             ,new CursorDef("T000H7", "SELECT [GestorCod] AS GestorCod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @GestorCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H7,1,0,true,false )
             ,new CursorDef("T000H8", "SELECT TOP 1 [GestorCod] AS GestorCod FROM [GESTORES] WITH (NOLOCK) WHERE ( [GestorCod] > @GestorCod) ORDER BY [GestorCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H8,1,0,true,true )
             ,new CursorDef("T000H9", "SELECT TOP 1 [GestorCod] AS GestorCod FROM [GESTORES] WITH (NOLOCK) WHERE ( [GestorCod] < @GestorCod) ORDER BY [GestorCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H9,1,0,true,true )
             ,new CursorDef("T000H10", "SELECT [GestorRolCod], [GestorRolDes], [GestorRamoCod], [GestorRamoDes], [GestorCod] AS GestorCod FROM [GESTORES] WITH (UPDLOCK) WHERE [GestorCod] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H10,1,0,true,false )
             ,new CursorDef("T000H11", "INSERT INTO [GESTORES] ([GestorRolCod], [GestorRolDes], [GestorRamoCod], [GestorRamoDes], [GestorCod]) VALUES (@GestorRolCod, @GestorRolDes, @GestorRamoCod, @GestorRamoDes, @GestorCod)", GxErrorMask.GX_NOMASK,prmT000H11)
             ,new CursorDef("T000H12", "UPDATE [GESTORES] SET [GestorRolCod]=@GestorRolCod, [GestorRolDes]=@GestorRolDes, [GestorRamoCod]=@GestorRamoCod, [GestorRamoDes]=@GestorRamoDes  WHERE [GestorCod] = @GestorCod", GxErrorMask.GX_NOMASK,prmT000H12)
             ,new CursorDef("T000H13", "DELETE FROM [GESTORES]  WHERE [GestorCod] = @GestorCod", GxErrorMask.GX_NOMASK,prmT000H13)
             ,new CursorDef("T000H14", "SELECT [USU_DES] AS GestorDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H14,1,0,true,false )
             ,new CursorDef("T000H15", "SELECT TOP 1 [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) WHERE [GstEmpCod] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H15,1,0,true,true )
             ,new CursorDef("T000H16", "SELECT TOP 1 [Grupo_Cod], [Ges_Cod] FROM [GPO_GES] WITH (NOLOCK) WHERE [Ges_Cod] = @GestorCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H16,1,0,true,true )
             ,new CursorDef("T000H17", "SELECT [GestorCod] AS GestorCod FROM [GESTORES] WITH (NOLOCK) ORDER BY [GestorCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H17,100,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[8])[0] = rslt.getString(6, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                stmt.SetParameter(4, (String)parms[5]);
                stmt.SetParameter(5, (String)parms[6]);
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                stmt.SetParameter(4, (String)parms[5]);
                stmt.SetParameter(5, (String)parms[6]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
