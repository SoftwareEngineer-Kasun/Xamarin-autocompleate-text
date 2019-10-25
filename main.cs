//this event handler check when submit button pressed

protected void ClickedBtnSubmit(object sender, System.EventArgs e){ 
   if (autoComplete1.Text != ""){ 
      Toast.MakeText(this, "The Name Entered =" 
         + autoComplete1.Text, ToastLength.Short).Show(); 
   } else { 
      Toast.MakeText(this, "Enter a Name!", ToastLength.Short).Show(); 
   } 
} 

//here for run oncreate()

autoComplete1 = FindViewById<AutoCompleteTextView>(Resource.Id.autoComplete1); 
btn_Submit = FindViewById<Button>(Resource.Id.btn_Submit);  
// check for this objects
var names = new string[] { "John", "Peter", "Jane", "Britney" }; 
ArrayAdapter adapter = new ArrayAdapter<string>(this,           
   Android.Resource.Layout.SimpleSpinnerItem, names); 
autoComplete1.Adapter = adapter; 
btn_Submit.Click += ClickedBtnSubmit; 
