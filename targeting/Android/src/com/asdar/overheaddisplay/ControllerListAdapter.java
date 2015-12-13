package com.asdar.overheaddisplay;

import android.os.Bundle;

import android.app.Activity;
import android.view.Menu;
import android.widget.ArrayAdapter;

public class ControllerListAdapter extends ArrayAdapter<Controller> {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_list_view_adapter);
	}

}
