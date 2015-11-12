/*
               File: GPO_GES
        Description: Gestores por Grupo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:18.44
       Program type: Main program
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
   public class gpo_ges : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A270Ges_Cod = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A270Ges_Cod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A270Ges_Cod = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A270Ges_Cod) ;
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
               AV7Grupo_Cod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7Grupo_Cod), 4, 0)));
               AV8Ges_Cod = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Ges_Cod", AV8Ges_Cod);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Gestores por Grupo", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtGrupo_Cod_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public gpo_ges( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gpo_ges( IGxContext context )
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
                           short aP1_Grupo_Cod ,
                           String aP2_Ges_Cod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7Grupo_Cod = aP1_Grupo_Cod;
         this.AV8Ges_Cod = aP2_Ges_Cod;
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
            wb_table1_2_0L18( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0L18e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0L18( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0L18( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0L18e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Gestores por Grupo"+"</legend>") ;
            wb_table3_27_0L18( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0L18e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0L18e( true) ;
         }
         else
         {
            wb_table1_2_0L18e( false) ;
         }
      }

      protected void wb_table3_27_0L18( bool wbgen )
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
            wb_table4_33_0L18( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0L18e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_GPO_GES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_GPO_GES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0L18e( true) ;
         }
         else
         {
            wb_table3_27_0L18e( false) ;
         }
      }

      protected void wb_table4_33_0L18( bool wbgen )
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
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_cod_Internalname, 1, 1, 0, "Cod Grupo", "", "", "", 0, lblTextblockgrupo_cod_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtGrupo_Cod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A271Grupo_Cod), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtGrupo_Cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_des_Internalname, 1, 1, 0, "Grupo", "", "", "", 0, lblTextblockgrupo_des_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Des_Internalname, StringUtil.RTrim( A273Grupo_Des), "", 20, "chr", 1, "row", 20, 1, edtGrupo_Des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A273Grupo_Des, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, edtGrupo_Des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_tip_Internalname, 1, 1, 0, "Tipo (Int/Ext)", "", "", "", 0, lblTextblockgrupo_tip_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Tip_Internalname, StringUtil.RTrim( A275Grupo_Tip), "", 1, "chr", 1, "row", 1, 1, edtGrupo_Tip_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A275Grupo_Tip, "X")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", 0, edtGrupo_Tip_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockges_cod_Internalname, 1, 1, 0, "Cod Gestor", "", "", "", 0, lblTextblockges_cod_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGes_Cod_Internalname, StringUtil.RTrim( A270Ges_Cod), "", 15, "chr", 1, "row", 15, 1, edtGes_Cod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A270Ges_Cod, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(53);\"", 0, edtGes_Cod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GPO_GES.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_270_Internalname, "", "prompt.gif", "Modern", imgprompt_270_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_270_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockges_des_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockges_des_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Tahoma'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtGes_Des_Internalname, StringUtil.RTrim( A277Ges_Des), "", 50, "chr", 1, "row", 50, 1, edtGes_Des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A277Ges_Des, "@!")), "", 0, edtGes_Des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_GPO_GES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0L18e( true) ;
         }
         else
         {
            wb_table4_33_0L18e( false) ;
         }
      }

      protected void wb_table2_5_0L18( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GRUPO_COD"+"'), id:'"+"GRUPO_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"GES_COD"+"'), id:'"+"GES_COD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GRUPO_COD"+"'), id:'"+"GRUPO_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"GES_COD"+"'), id:'"+"GES_COD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GPO_GES.htm");
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
            wb_table2_5_0L18e( true) ;
         }
         else
         {
            wb_table2_5_0L18e( false) ;
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
         /* Execute user event: E110L2 */
         E110L2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtGrupo_Cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtGrupo_Cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtGrupo_Cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "GRUPO_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtGrupo_Cod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A271Grupo_Cod = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               }
               else
               {
                  A271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( edtGrupo_Cod_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               }
               A273Grupo_Des = cgiGet( edtGrupo_Des_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
               A275Grupo_Tip = cgiGet( edtGrupo_Tip_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
               A270Ges_Cod = StringUtil.Upper( cgiGet( edtGes_Cod_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
               A277Ges_Des = StringUtil.Upper( cgiGet( edtGes_Des_Internalname)) ;
               n277Ges_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
               /* Read saved values. */
               Z271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( "Z271Grupo_Cod"), ",", ".")) ;
               Z270Ges_Cod = cgiGet( "Z270Ges_Cod") ;
               Z273Grupo_Des = cgiGet( "Z273Grupo_Des") ;
               Z275Grupo_Tip = cgiGet( "Z275Grupo_Tip") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( "vGRUPO_COD"), ",", ".")) ;
               AV8Ges_Cod = cgiGet( "vGES_COD") ;
               AV13Pgmname = cgiGet( "vPGMNAME") ;
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
                  A271Grupo_Cod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
                  A270Ges_Cod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
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
                     sMode18 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode18 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound18 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0L0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "GRUPO_COD");
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
                           /* Execute user event: E110L2 */
                           E110L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120L2 */
                           E120L2 ();
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
            /* Execute user event: E120L2 */
            E120L2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0L18( ) ;
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
            edtGrupo_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Cod_Enabled), 5, 0)));
            edtGrupo_Des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Des_Enabled), 5, 0)));
            edtGrupo_Tip_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Tip_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Tip_Enabled), 5, 0)));
            edtGes_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGes_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGes_Cod_Enabled), 5, 0)));
            edtGes_Des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGes_Des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGes_Des_Enabled), 5, 0)));
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

      protected void CONFIRM_0L0( )
      {
         BeforeValidate0L18( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0L18( ) ;
            }
            else
            {
               CheckExtendedTable0L18( ) ;
               CloseExtendedTableCursors0L18( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0L0( )
      {
      }

      protected void E110L2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV13Pgmname, out  AV10IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", StringUtil.BoolToStr( AV10IsAuthorized));
         if ( ! AV10IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)) ;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), "");
      }

      protected void E120L2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwgpo_ges.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0L18( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z273Grupo_Des = T000L3_A273Grupo_Des[0] ;
               Z275Grupo_Tip = T000L3_A275Grupo_Tip[0] ;
            }
            else
            {
               Z273Grupo_Des = A273Grupo_Des ;
               Z275Grupo_Tip = A275Grupo_Tip ;
            }
         }
         if ( GX_JID == -7 )
         {
            Z271Grupo_Cod = A271Grupo_Cod ;
            Z273Grupo_Des = A273Grupo_Des ;
            Z275Grupo_Tip = A275Grupo_Tip ;
            Z270Ges_Cod = A270Ges_Cod ;
            Z277Ges_Des = A277Ges_Des ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_270_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00h0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GES_COD"+"'), id:'"+"GES_COD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! (0==AV7Grupo_Cod) )
         {
            A271Grupo_Cod = AV7Grupo_Cod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
         }
         if ( ! (0==AV7Grupo_Cod) )
         {
            edtGrupo_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Cod_Enabled), 5, 0)));
         }
         else
         {
            edtGrupo_Cod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Cod_Enabled), 5, 0)));
         }
         if ( ! (0==AV7Grupo_Cod) )
         {
            edtGrupo_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Cod_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8Ges_Cod)) )
         {
            A270Ges_Cod = AV8Ges_Cod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8Ges_Cod)) )
         {
            edtGes_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGes_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGes_Cod_Enabled), 5, 0)));
         }
         else
         {
            edtGes_Cod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGes_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGes_Cod_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8Ges_Cod)) )
         {
            edtGes_Cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGes_Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGes_Cod_Enabled), 5, 0)));
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
            AV13Pgmname = "GPO_GES" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000L5 */
            pr_default.execute(3, new Object[] {A270Ges_Cod});
            A277Ges_Des = T000L5_A277Ges_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
            n277Ges_Des = T000L5_n277Ges_Des[0] ;
            pr_default.close(3);
         }
      }

      protected void Load0L18( )
      {
         /* Using cursor T000L6 */
         pr_default.execute(4, new Object[] {A271Grupo_Cod, A270Ges_Cod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound18 = 1 ;
            A273Grupo_Des = T000L6_A273Grupo_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
            A275Grupo_Tip = T000L6_A275Grupo_Tip[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
            A277Ges_Des = T000L6_A277Ges_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
            n277Ges_Des = T000L6_n277Ges_Des[0] ;
            ZM0L18( -7) ;
         }
         pr_default.close(4);
         OnLoadActions0L18( ) ;
      }

      protected void OnLoadActions0L18( )
      {
         AV13Pgmname = "GPO_GES" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable0L18( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV13Pgmname = "GPO_GES" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T000L4 */
         pr_default.execute(2, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(2);
         /* Using cursor T000L5 */
         pr_default.execute(3, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A277Ges_Des = T000L5_A277Ges_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
            n277Ges_Des = T000L5_n277Ges_Des[0] ;
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0L18( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( String A270Ges_Cod )
      {
         /* Using cursor T000L7 */
         pr_default.execute(5, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_9( String A270Ges_Cod )
      {
         /* Using cursor T000L8 */
         pr_default.execute(6, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A277Ges_Des = T000L8_A277Ges_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
            n277Ges_Des = T000L8_n277Ges_Des[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A277Ges_Des))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0L18( )
      {
         /* Using cursor T000L9 */
         pr_default.execute(7, new Object[] {A271Grupo_Cod, A270Ges_Cod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound18 = 1 ;
         }
         else
         {
            RcdFound18 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000L3 */
         pr_default.execute(1, new Object[] {A271Grupo_Cod, A270Ges_Cod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0L18( 7) ;
            RcdFound18 = 1 ;
            A271Grupo_Cod = T000L3_A271Grupo_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            A273Grupo_Des = T000L3_A273Grupo_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
            A275Grupo_Tip = T000L3_A275Grupo_Tip[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
            A270Ges_Cod = T000L3_A270Ges_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
            Z271Grupo_Cod = A271Grupo_Cod ;
            Z270Ges_Cod = A270Ges_Cod ;
            sMode18 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0L18( ) ;
            Gx_mode = sMode18 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound18 = 0 ;
            InitializeNonKey0L18( ) ;
            sMode18 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode18 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0L18( ) ;
         if ( RcdFound18 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound18 = 0 ;
         /* Using cursor T000L10 */
         pr_default.execute(8, new Object[] {A271Grupo_Cod, A270Ges_Cod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000L10_A271Grupo_Cod[0] < A271Grupo_Cod ) || ( T000L10_A271Grupo_Cod[0] == A271Grupo_Cod ) && ( StringUtil.StrCmp(T000L10_A270Ges_Cod[0], A270Ges_Cod) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000L10_A271Grupo_Cod[0] > A271Grupo_Cod ) || ( T000L10_A271Grupo_Cod[0] == A271Grupo_Cod ) && ( StringUtil.StrCmp(T000L10_A270Ges_Cod[0], A270Ges_Cod) > 0 ) ) )
            {
               A271Grupo_Cod = T000L10_A271Grupo_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               A270Ges_Cod = T000L10_A270Ges_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
               RcdFound18 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound18 = 0 ;
         /* Using cursor T000L11 */
         pr_default.execute(9, new Object[] {A271Grupo_Cod, A270Ges_Cod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000L11_A271Grupo_Cod[0] > A271Grupo_Cod ) || ( T000L11_A271Grupo_Cod[0] == A271Grupo_Cod ) && ( StringUtil.StrCmp(T000L11_A270Ges_Cod[0], A270Ges_Cod) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000L11_A271Grupo_Cod[0] < A271Grupo_Cod ) || ( T000L11_A271Grupo_Cod[0] == A271Grupo_Cod ) && ( StringUtil.StrCmp(T000L11_A270Ges_Cod[0], A270Ges_Cod) < 0 ) ) )
            {
               A271Grupo_Cod = T000L11_A271Grupo_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               A270Ges_Cod = T000L11_A270Ges_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
               RcdFound18 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0L18( ) ;
         if ( RcdFound18 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "GRUPO_COD");
               AnyError = 1 ;
               GX_FocusControl = edtGrupo_Cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A271Grupo_Cod != Z271Grupo_Cod ) || ( StringUtil.StrCmp(A270Ges_Cod, Z270Ges_Cod) != 0 ) )
            {
               A271Grupo_Cod = Z271Grupo_Cod ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               A270Ges_Cod = Z270Ges_Cod ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "GRUPO_COD");
               AnyError = 1 ;
               GX_FocusControl = edtGrupo_Cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtGrupo_Cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0L18( ) ;
               GX_FocusControl = edtGrupo_Cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A271Grupo_Cod != Z271Grupo_Cod ) || ( StringUtil.StrCmp(A270Ges_Cod, Z270Ges_Cod) != 0 ) )
            {
               /* Insert record */
               Insert0L18( ) ;
               GX_FocusControl = edtGrupo_Cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "GRUPO_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtGrupo_Cod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0L18( ) ;
                  GX_FocusControl = edtGrupo_Cod_Internalname ;
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
         if ( ( A271Grupo_Cod != Z271Grupo_Cod ) || ( StringUtil.StrCmp(A270Ges_Cod, Z270Ges_Cod) != 0 ) )
         {
            A271Grupo_Cod = Z271Grupo_Cod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            A270Ges_Cod = Z270Ges_Cod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "GRUPO_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGrupo_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtGrupo_Cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0L18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L12 */
            pr_default.execute(10, new Object[] {A271Grupo_Cod, A270Ges_Cod});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GPO_GES"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z273Grupo_Des, T000L12_A273Grupo_Des[0]) != 0 ) || ( StringUtil.StrCmp(Z275Grupo_Tip, T000L12_A275Grupo_Tip[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"GPO_GES"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0L18( )
      {
         BeforeValidate0L18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L18( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L18( 0) ;
            CheckOptimisticConcurrency0L18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L13 */
                     pr_default.execute(11, new Object[] {A271Grupo_Cod, A273Grupo_Des, A275Grupo_Tip, A270Ges_Cod});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 1) )
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
                           ResetCaption0L0( ) ;
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
               Load0L18( ) ;
            }
            EndLevel0L18( ) ;
         }
         CloseExtendedTableCursors0L18( ) ;
      }

      protected void Update0L18( )
      {
         BeforeValidate0L18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L18( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L14 */
                     pr_default.execute(12, new Object[] {A273Grupo_Des, A275Grupo_Tip, A271Grupo_Cod, A270Ges_Cod});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GPO_GES"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0L18( ) ;
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
            EndLevel0L18( ) ;
         }
         CloseExtendedTableCursors0L18( ) ;
      }

      protected void DeferredUpdate0L18( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0L18( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L18( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L18( ) ;
            AfterConfirm0L18( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L18( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000L15 */
                  pr_default.execute(13, new Object[] {A271Grupo_Cod, A270Ges_Cod});
                  pr_default.close(13);
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
         sMode18 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0L18( ) ;
         Gx_mode = sMode18 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0L18( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "GPO_GES" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000L16 */
            pr_default.execute(14, new Object[] {A270Ges_Cod});
            A277Ges_Des = T000L16_A277Ges_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
            n277Ges_Des = T000L16_n277Ges_Des[0] ;
            pr_default.close(14);
         }
      }

      protected void EndLevel0L18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0L18( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            context.CommitDataStores("GPO_GES");
            if ( AnyError == 0 )
            {
               ConfirmValues0L0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            context.RollbackDataStores("GPO_GES");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0L18( )
      {
         /* Using cursor T000L17 */
         pr_default.execute(15);
         RcdFound18 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound18 = 1 ;
            A271Grupo_Cod = T000L17_A271Grupo_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            A270Ges_Cod = T000L17_A270Ges_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L18( )
      {
         pr_default.readNext(15);
         RcdFound18 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound18 = 1 ;
            A271Grupo_Cod = T000L17_A271Grupo_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            A270Ges_Cod = T000L17_A270Ges_Cod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
         }
      }

      protected void ScanEnd0L18( )
      {
      }

      protected void AfterConfirm0L18( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L18( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L18( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L18( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L18( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L18( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0L0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gpo_ges.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7Grupo_Cod) + "," + UrlEncode(StringUtil.RTrim(AV8Ges_Cod))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z271Grupo_Cod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z271Grupo_Cod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z270Ges_Cod", StringUtil.RTrim( Z270Ges_Cod));
         GxWebStd.gx_hidden_field( context, "Z273Grupo_Des", StringUtil.RTrim( Z273Grupo_Des));
         GxWebStd.gx_hidden_field( context, "Z275Grupo_Tip", StringUtil.RTrim( Z275Grupo_Tip));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vGRUPO_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7Grupo_Cod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGES_COD", StringUtil.RTrim( AV8Ges_Cod));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
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
         return "GPO_GES" ;
      }

      public override String GetPgmdesc( )
      {
         return "Gestores por Grupo" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gpo_ges.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7Grupo_Cod) + "," + UrlEncode(StringUtil.RTrim(AV8Ges_Cod)) ;
      }

      protected void InitializeNonKey0L18( )
      {
         A273Grupo_Des = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
         A275Grupo_Tip = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
         A277Ges_Des = "" ;
         n277Ges_Des = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277Ges_Des", A277Ges_Des);
      }

      protected void InitAll0L18( )
      {
         A271Grupo_Cod = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
         A270Ges_Cod = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
         InitializeNonKey0L18( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19171973");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gpo_ges.js", "?19171973");
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
         lblTextblockgrupo_cod_Internalname = "TEXTBLOCKGRUPO_COD" ;
         edtGrupo_Cod_Internalname = "GRUPO_COD" ;
         lblTextblockgrupo_des_Internalname = "TEXTBLOCKGRUPO_DES" ;
         edtGrupo_Des_Internalname = "GRUPO_DES" ;
         lblTextblockgrupo_tip_Internalname = "TEXTBLOCKGRUPO_TIP" ;
         edtGrupo_Tip_Internalname = "GRUPO_TIP" ;
         lblTextblockges_cod_Internalname = "TEXTBLOCKGES_COD" ;
         edtGes_Cod_Internalname = "GES_COD" ;
         lblTextblockges_des_Internalname = "TEXTBLOCKGES_DES" ;
         edtGes_Des_Internalname = "GES_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_270_Internalname = "PROMPT_270" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Gestores por Grupo" ;
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
         edtGes_Des_Jsonclick = "" ;
         edtGes_Des_Enabled = 0 ;
         imgprompt_270_Visible = 1 ;
         imgprompt_270_Link = "" ;
         edtGes_Cod_Jsonclick = "" ;
         edtGes_Cod_Enabled = 1 ;
         edtGrupo_Tip_Jsonclick = "" ;
         edtGrupo_Tip_Enabled = 1 ;
         edtGrupo_Des_Jsonclick = "" ;
         edtGrupo_Des_Enabled = 1 ;
         edtGrupo_Cod_Jsonclick = "" ;
         edtGrupo_Cod_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Ges_cod( String GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A270Ges_Cod = GX_Parm1 ;
         A277Ges_Des = GX_Parm2 ;
         n277Ges_Des = false ;
         /* Using cursor T000L18 */
         pr_default.execute(16, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(16);
         /* Using cursor T000L16 */
         pr_default.execute(14, new Object[] {A270Ges_Cod});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'GES_ GPO'.", "ForeignKeyNotFound", 1, "GES_COD");
            AnyError = 1 ;
            GX_FocusControl = edtGes_Cod_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A277Ges_Des = T000L16_A277Ges_Des[0] ;
            n277Ges_Des = T000L16_n277Ges_Des[0] ;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A277Ges_Des = "" ;
            n277Ges_Des = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A277Ges_Des)));
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
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(16);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV8Ges_Cod = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A270Ges_Cod = "" ;
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
         lblTextblockgrupo_cod_Jsonclick = "" ;
         lblTextblockgrupo_des_Jsonclick = "" ;
         A273Grupo_Des = "" ;
         lblTextblockgrupo_tip_Jsonclick = "" ;
         A275Grupo_Tip = "" ;
         lblTextblockges_cod_Jsonclick = "" ;
         lblTextblockges_des_Jsonclick = "" ;
         A277Ges_Des = "" ;
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
         Z270Ges_Cod = "" ;
         Z273Grupo_Des = "" ;
         Z275Grupo_Tip = "" ;
         AV13Pgmname = "" ;
         sMode18 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = new GxWebSession( context);
         Z277Ges_Des = "" ;
         T000L5_A277Ges_Des = new String[] {""} ;
         T000L5_n277Ges_Des = new bool[] {false} ;
         T000L6_A271Grupo_Cod = new short[1] ;
         T000L6_A273Grupo_Des = new String[] {""} ;
         T000L6_A275Grupo_Tip = new String[] {""} ;
         T000L6_A277Ges_Des = new String[] {""} ;
         T000L6_n277Ges_Des = new bool[] {false} ;
         T000L6_A270Ges_Cod = new String[] {""} ;
         T000L4_A270Ges_Cod = new String[] {""} ;
         T000L7_A270Ges_Cod = new String[] {""} ;
         T000L8_A277Ges_Des = new String[] {""} ;
         T000L8_n277Ges_Des = new bool[] {false} ;
         T000L9_A271Grupo_Cod = new short[1] ;
         T000L9_A270Ges_Cod = new String[] {""} ;
         T000L3_A271Grupo_Cod = new short[1] ;
         T000L3_A273Grupo_Des = new String[] {""} ;
         T000L3_A275Grupo_Tip = new String[] {""} ;
         T000L3_A270Ges_Cod = new String[] {""} ;
         T000L10_A271Grupo_Cod = new short[1] ;
         T000L10_A270Ges_Cod = new String[] {""} ;
         T000L11_A271Grupo_Cod = new short[1] ;
         T000L11_A270Ges_Cod = new String[] {""} ;
         T000L12_A271Grupo_Cod = new short[1] ;
         T000L12_A273Grupo_Des = new String[] {""} ;
         T000L12_A275Grupo_Tip = new String[] {""} ;
         T000L12_A270Ges_Cod = new String[] {""} ;
         T000L16_A277Ges_Des = new String[] {""} ;
         T000L16_n277Ges_Des = new bool[] {false} ;
         T000L17_A271Grupo_Cod = new short[1] ;
         T000L17_A270Ges_Cod = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T000L18_A270Ges_Cod = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gpo_ges__default(),
            new Object[][] {
                new Object[] {
               T000L2_A271Grupo_Cod, T000L2_A273Grupo_Des, T000L2_A275Grupo_Tip, T000L2_A270Ges_Cod
               }
               , new Object[] {
               T000L3_A271Grupo_Cod, T000L3_A273Grupo_Des, T000L3_A275Grupo_Tip, T000L3_A270Ges_Cod
               }
               , new Object[] {
               T000L4_A270Ges_Cod
               }
               , new Object[] {
               T000L5_A277Ges_Des, T000L5_n277Ges_Des
               }
               , new Object[] {
               T000L6_A271Grupo_Cod, T000L6_A273Grupo_Des, T000L6_A275Grupo_Tip, T000L6_A277Ges_Des, T000L6_n277Ges_Des, T000L6_A270Ges_Cod
               }
               , new Object[] {
               T000L7_A270Ges_Cod
               }
               , new Object[] {
               T000L8_A277Ges_Des, T000L8_n277Ges_Des
               }
               , new Object[] {
               T000L9_A271Grupo_Cod, T000L9_A270Ges_Cod
               }
               , new Object[] {
               T000L10_A271Grupo_Cod, T000L10_A270Ges_Cod
               }
               , new Object[] {
               T000L11_A271Grupo_Cod, T000L11_A270Ges_Cod
               }
               , new Object[] {
               T000L12_A271Grupo_Cod, T000L12_A273Grupo_Des, T000L12_A275Grupo_Tip, T000L12_A270Ges_Cod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L16_A277Ges_Des, T000L16_n277Ges_Des
               }
               , new Object[] {
               T000L17_A271Grupo_Cod, T000L17_A270Ges_Cod
               }
               , new Object[] {
               T000L18_A270Ges_Cod
               }
            }
         );
         AV13Pgmname = "GPO_GES" ;
      }

      private short wcpOAV7Grupo_Cod ;
      private short GxWebError ;
      private short AV7Grupo_Cod ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A271Grupo_Cod ;
      private short Z271Grupo_Cod ;
      private short RcdFound18 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtGrupo_Cod_Enabled ;
      private int edtGrupo_Des_Enabled ;
      private int edtGrupo_Tip_Enabled ;
      private int edtGes_Cod_Enabled ;
      private int imgprompt_270_Visible ;
      private int edtGes_Des_Enabled ;
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
      private String wcpOAV8Ges_Cod ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A270Ges_Cod ;
      private String Gx_mode ;
      private String AV8Ges_Cod ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtGrupo_Cod_Internalname ;
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
      private String lblTextblockgrupo_cod_Internalname ;
      private String lblTextblockgrupo_cod_Jsonclick ;
      private String edtGrupo_Cod_Jsonclick ;
      private String lblTextblockgrupo_des_Internalname ;
      private String lblTextblockgrupo_des_Jsonclick ;
      private String edtGrupo_Des_Internalname ;
      private String A273Grupo_Des ;
      private String edtGrupo_Des_Jsonclick ;
      private String lblTextblockgrupo_tip_Internalname ;
      private String lblTextblockgrupo_tip_Jsonclick ;
      private String edtGrupo_Tip_Internalname ;
      private String A275Grupo_Tip ;
      private String edtGrupo_Tip_Jsonclick ;
      private String lblTextblockges_cod_Internalname ;
      private String lblTextblockges_cod_Jsonclick ;
      private String edtGes_Cod_Internalname ;
      private String edtGes_Cod_Jsonclick ;
      private String imgprompt_270_Internalname ;
      private String imgprompt_270_Link ;
      private String lblTextblockges_des_Internalname ;
      private String lblTextblockges_des_Jsonclick ;
      private String edtGes_Des_Internalname ;
      private String A277Ges_Des ;
      private String edtGes_Des_Jsonclick ;
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
      private String Z270Ges_Cod ;
      private String Z273Grupo_Des ;
      private String Z275Grupo_Tip ;
      private String AV13Pgmname ;
      private String sMode18 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z277Ges_Des ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n277Ges_Des ;
      private bool AV10IsAuthorized ;
      private bool returnInSub ;
      private GxWebSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000L5_A277Ges_Des ;
      private bool[] T000L5_n277Ges_Des ;
      private short[] T000L6_A271Grupo_Cod ;
      private String[] T000L6_A273Grupo_Des ;
      private String[] T000L6_A275Grupo_Tip ;
      private String[] T000L6_A277Ges_Des ;
      private bool[] T000L6_n277Ges_Des ;
      private String[] T000L6_A270Ges_Cod ;
      private String[] T000L4_A270Ges_Cod ;
      private String[] T000L7_A270Ges_Cod ;
      private String[] T000L8_A277Ges_Des ;
      private bool[] T000L8_n277Ges_Des ;
      private short[] T000L9_A271Grupo_Cod ;
      private String[] T000L9_A270Ges_Cod ;
      private short[] T000L3_A271Grupo_Cod ;
      private String[] T000L3_A273Grupo_Des ;
      private String[] T000L3_A275Grupo_Tip ;
      private String[] T000L3_A270Ges_Cod ;
      private short[] T000L10_A271Grupo_Cod ;
      private String[] T000L10_A270Ges_Cod ;
      private short[] T000L11_A271Grupo_Cod ;
      private String[] T000L11_A270Ges_Cod ;
      private short[] T000L12_A271Grupo_Cod ;
      private String[] T000L12_A273Grupo_Des ;
      private String[] T000L12_A275Grupo_Tip ;
      private String[] T000L12_A270Ges_Cod ;
      private String[] T000L16_A277Ges_Des ;
      private bool[] T000L16_n277Ges_Des ;
      private short[] T000L17_A271Grupo_Cod ;
      private String[] T000L17_A270Ges_Cod ;
      private String[] T000L18_A270Ges_Cod ;
      private short[] T000L2_A271Grupo_Cod ;
      private String[] T000L2_A273Grupo_Des ;
      private String[] T000L2_A275Grupo_Tip ;
      private String[] T000L2_A270Ges_Cod ;
      private GXWebForm Form ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class gpo_ges__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000L2 ;
          prmT000L2 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L6 ;
          prmT000L6 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L4 ;
          prmT000L4 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L5 ;
          prmT000L5 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L7 ;
          prmT000L7 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L8 ;
          prmT000L8 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L9 ;
          prmT000L9 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L3 ;
          prmT000L3 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L10 ;
          prmT000L10 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L11 ;
          prmT000L11 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L12 ;
          prmT000L12 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L13 ;
          prmT000L13 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Grupo_Des",SqlDbType.Char,20,0} ,
          new Object[] {"@Grupo_Tip",SqlDbType.Char,1,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L14 ;
          prmT000L14 = new Object[] {
          new Object[] {"@Grupo_Des",SqlDbType.Char,20,0} ,
          new Object[] {"@Grupo_Tip",SqlDbType.Char,1,0} ,
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L15 ;
          prmT000L15 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L17 ;
          prmT000L17 = new Object[] {
          } ;
          Object[] prmT000L18 ;
          prmT000L18 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L16 ;
          prmT000L16 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000L2", "SELECT [Grupo_Cod], [Grupo_Des], [Grupo_Tip], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (UPDLOCK) WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L2,1,0,true,false )
             ,new CursorDef("T000L3", "SELECT [Grupo_Cod], [Grupo_Des], [Grupo_Tip], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (NOLOCK) WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L3,1,0,true,false )
             ,new CursorDef("T000L4", "SELECT [GestorCod] AS Ges_Cod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L4,1,0,true,false )
             ,new CursorDef("T000L5", "SELECT [USU_DES] AS Ges_Des FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L5,1,0,true,false )
             ,new CursorDef("T000L6", "SELECT TM1.[Grupo_Cod], TM1.[Grupo_Des], TM1.[Grupo_Tip], T3.[USU_DES] AS Ges_Des, TM1.[Ges_Cod] AS Ges_Cod FROM (([GPO_GES] TM1 WITH (NOLOCK) INNER JOIN [GESTORES] T2 WITH (NOLOCK) ON T2.[GestorCod] = TM1.[Ges_Cod]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T2.[GestorCod]) WHERE TM1.[Grupo_Cod] = @Grupo_Cod and TM1.[Ges_Cod] = @Ges_Cod ORDER BY TM1.[Grupo_Cod], TM1.[Ges_Cod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L6,100,0,true,false )
             ,new CursorDef("T000L7", "SELECT [GestorCod] AS Ges_Cod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L7,1,0,true,false )
             ,new CursorDef("T000L8", "SELECT [USU_DES] AS Ges_Des FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L8,1,0,true,false )
             ,new CursorDef("T000L9", "SELECT [Grupo_Cod], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (NOLOCK) WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L9,1,0,true,false )
             ,new CursorDef("T000L10", "SELECT TOP 1 [Grupo_Cod], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (NOLOCK) WHERE ( [Grupo_Cod] > @Grupo_Cod or [Grupo_Cod] = @Grupo_Cod and [Ges_Cod] > @Ges_Cod) ORDER BY [Grupo_Cod], [Ges_Cod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L10,1,0,true,true )
             ,new CursorDef("T000L11", "SELECT TOP 1 [Grupo_Cod], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (NOLOCK) WHERE ( [Grupo_Cod] < @Grupo_Cod or [Grupo_Cod] = @Grupo_Cod and [Ges_Cod] < @Ges_Cod) ORDER BY [Grupo_Cod] DESC, [Ges_Cod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L11,1,0,true,true )
             ,new CursorDef("T000L12", "SELECT [Grupo_Cod], [Grupo_Des], [Grupo_Tip], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (UPDLOCK) WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L12,1,0,true,false )
             ,new CursorDef("T000L13", "INSERT INTO [GPO_GES] ([Grupo_Cod], [Grupo_Des], [Grupo_Tip], [Ges_Cod]) VALUES (@Grupo_Cod, @Grupo_Des, @Grupo_Tip, @Ges_Cod)", GxErrorMask.GX_NOMASK,prmT000L13)
             ,new CursorDef("T000L14", "UPDATE [GPO_GES] SET [Grupo_Des]=@Grupo_Des, [Grupo_Tip]=@Grupo_Tip  WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod", GxErrorMask.GX_NOMASK,prmT000L14)
             ,new CursorDef("T000L15", "DELETE FROM [GPO_GES]  WHERE [Grupo_Cod] = @Grupo_Cod AND [Ges_Cod] = @Ges_Cod", GxErrorMask.GX_NOMASK,prmT000L15)
             ,new CursorDef("T000L16", "SELECT [USU_DES] AS Ges_Des FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L16,1,0,true,false )
             ,new CursorDef("T000L17", "SELECT [Grupo_Cod], [Ges_Cod] AS Ges_Cod FROM [GPO_GES] WITH (NOLOCK) ORDER BY [Grupo_Cod], [Ges_Cod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L17,100,0,true,false )
             ,new CursorDef("T000L18", "SELECT [GestorCod] AS Ges_Cod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @Ges_Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L18,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 15) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                break;
             case 16 :
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
